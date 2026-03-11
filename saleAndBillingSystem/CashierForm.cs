using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saleAndBillingSystem
{
    public partial class CashierForm : Form
    {
        private string cashierName;
        private int lastSaleId = 0;  // to remember the latest sale ID
        private PrintDocument printDocument1 = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        private IDiscountStrategy _discountStrategy; // Strategy Pattern

        public CashierForm(loginForm loginForm)
        {
            InitializeComponent();
            this.Load += CashierForm_Load;
            cashierName = loginForm.LoggedInCashier;
            _discountStrategy = new NoDiscountStrategy(); // Default strategy
        }

        private void LoadProducts()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                string query = "SELECT ProductID, ProductName, Price FROM Products";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbProduct.DisplayMember = "ProductName";
                cmbProduct.ValueMember = "ProductID";
                cmbProduct.DataSource = dt;
            }
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;
            LoadProducts();
            
            // បើមាន Columns ចាស់ទេ ទើបចាប់ផ្តើមបន្ថែម
            dgvCart.Columns.Clear();

            // បន្ថែម Columns
            dgvCart.Columns.Add("ProductName", "Product Name");
            dgvCart.Columns.Add("UnitPrice", "Unit Price");
            dgvCart.Columns.Add("Quantity", "Quantity");
            dgvCart.Columns.Add("Total", "Total");
            dgvCart.Columns.Add("SubTotal", "SubTotal");

            // កំណត់ទំហំ Column
            dgvCart.Columns["ProductName"].Width = 150;
            dgvCart.Columns["UnitPrice"].Width = 80;
            dgvCart.Columns["Quantity"].Width = 70;
            dgvCart.Columns["Total"].Width = 100;
            dgvCart.Columns["SubTotal"].Width = 100;

            // ឲ្យ SubTotal មិនអាចកែបាន
            dgvCart.Columns["SubTotal"].ReadOnly = true;
        }

        private void cmbProduct_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedValue != null)
            {
                DataRowView drv = cmbProduct.SelectedItem as DataRowView;
                txtPrice.Text = drv["Price"].ToString();
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            string productName = cmbProduct.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            int qty = int.Parse(txtQuantity.Text);

            decimal subtotal = price * qty;

            dgvCart.Rows.Add(productName, price, qty, subtotal);

            UpdateTotalLabel();
        }

        private void UpdateTotalLabel()
        {
            decimal grandTotal = 0;

            // គណនាប្រាក់សរុបពីទំនិញទាំងអស់នៅក្នុង cart
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (!row.IsNewRow && row.Cells["Total"].Value != null)
                {
                    grandTotal += Convert.ToDecimal(row.Cells["Total"].Value);

                    // កំណត់ SubTotal column សម្រាប់ row នីមួយៗ (ប្រសិនបើចង់)
                    row.Cells["SubTotal"].Value = row.Cells["Total"].Value;
                }
            }

            // Strategy pattern applied
            decimal discount = _discountStrategy.CalculateDiscount(grandTotal);
            grandTotal -= discount;

            // បង្ហាញនៅ lblTotal
            lblTotal.Text = "Total: $" + grandTotal.ToString("0.00");
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            decimal grandTotal = 0;
            string cashier = cashierName;

            // គណនាប្រាក់សរុបពីទំនិញទាំងអស់នៅក្នុង cart
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (!row.IsNewRow)
                {
                    grandTotal += Convert.ToDecimal(row.Cells["SubTotal"].Value);
                }
            }

            // Apply Strategy Pattern Discount
            decimal discount = _discountStrategy.CalculateDiscount(grandTotal);
            grandTotal -= discount;

            // ឈ្មោះអ្នកគិតលុយ (អ្នកអាចយកពី LoginForm)
            //string cashierName = "Cashier1"; // ប្តូរជាឈ្មោះអ្នកបាន login

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                // ✅ ជំហានទី១៖ បញ្ចូលទៅក្នុង Sales table
                string insertSale = "INSERT INTO Sales (CashierName, SaleDate, TotalAmount) OUTPUT INSERTED.SaleID VALUES (@cashier, GETDATE(), @total)";
                SqlCommand cmdSale = new SqlCommand(insertSale, conn);
                cmdSale.Parameters.AddWithValue("@cashier", cashier);
                cmdSale.Parameters.AddWithValue("@total", grandTotal);

                // ទទួលបាន SaleID ថ្មី
                int saleId = (int)cmdSale.ExecuteScalar();
                lastSaleId = saleId;

                // ✅ ជំហានទី២៖ បញ្ចូលទិន្នន័យទៅ SaleDetails
                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    if (row.IsNewRow) continue;

                    string productName = row.Cells["ProductName"].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                    decimal subTotal = Convert.ToDecimal(row.Cells["SubTotal"].Value);

                    SqlCommand cmdDetail = new SqlCommand(
                        "INSERT INTO SaleDetails (SaleID, ProductName, Quantity, UnitPrice) VALUES (@sid, @pname, @qty, @price)",
                        conn
                    );

                    cmdDetail.Parameters.AddWithValue("@sid", saleId);
                    cmdDetail.Parameters.AddWithValue("@pname", productName);
                    cmdDetail.Parameters.AddWithValue("@qty", quantity);
                    cmdDetail.Parameters.AddWithValue("@price", unitPrice);
                    cmdDetail.ExecuteNonQuery();

                    // បន្ទាន់សម័យចំនួនទំនិញនៅក្នុង Products
                    SqlCommand cmdUpdate = new SqlCommand("UPDATE Products SET Quantity = Quantity - @qty WHERE ProductName = @pname", conn);
                    cmdUpdate.Parameters.AddWithValue("@qty", quantity);
                    cmdUpdate.Parameters.AddWithValue("@pname", productName);
                    cmdUpdate.ExecuteNonQuery();
                }

                conn.Close();
            }

            MessageBox.Show("✅ ការលក់បានបញ្ចប់ដោយជោគជ័យ!", "ជោគជ័យ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Observer Pattern: Notify subscribers that a sale was made
            EventAggregator.Instance.PublishSaleMade();

            dgvCart.Rows.Clear();
            lblTotal.Text = "Total: $0.00";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvCart.Rows.Clear();
            lblTotal.Text = "Total: $0.00";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Hide();

                loginForm login = new loginForm();
                login.Show();
            }
            else
            {
                return;
            }
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            if (lastSaleId == 0)
            {
                MessageBox.Show("No sale found to print. Please complete a checkout first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            printDocument1.PrintPage += PrintDocument1_PrintPage;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                // 🧾 Get Sale Info
                SqlCommand cmdSale = new SqlCommand("SELECT * FROM Sales WHERE SaleID=@id", conn);
                cmdSale.Parameters.AddWithValue("@id", lastSaleId);
                SqlDataReader saleReader = cmdSale.ExecuteReader();
                saleReader.Read();

                string cashier = saleReader["CashierName"].ToString();
                DateTime saleDate = Convert.ToDateTime(saleReader["SaleDate"]);
                decimal total = Convert.ToDecimal(saleReader["TotalAmount"]);
                saleReader.Close();

                // 🧾 Get Sale Details
                SqlCommand cmdDetails = new SqlCommand("SELECT ProductName, Quantity, UnitPrice FROM SaleDetails WHERE SaleID=@id", conn);
                cmdDetails.Parameters.AddWithValue("@id", lastSaleId);
                SqlDataReader dr = cmdDetails.ExecuteReader();

                // 🖨 Print Header
                int y = 60;
                e.Graphics.DrawString("🛒 Sale Invoice", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 250, y);
                y += 40;
                e.Graphics.DrawString($"Sale ID: {lastSaleId}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 50, y);
                y += 20;
                e.Graphics.DrawString($"Cashier: {cashier}", new Font("Arial", 10), Brushes.Black, 50, y);
                y += 20;
                e.Graphics.DrawString($"Date: {saleDate}", new Font("Arial", 10), Brushes.Black, 50, y);
                y += 30;
                e.Graphics.DrawLine(Pens.Black, 50, y, 750, y);
                y += 20;

                // 🧾 Table Headers
                e.Graphics.DrawString("Product", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 60, y);
                e.Graphics.DrawString("Qty", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 250, y);
                e.Graphics.DrawString("Price", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 350, y);
                e.Graphics.DrawString("Total", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 450, y);
                y += 25;
                e.Graphics.DrawLine(Pens.Black, 50, y, 750, y);
                y += 10;

                // 🧾 Print Each Item
                while (dr.Read())
                {
                    string pname = dr["ProductName"].ToString();
                    int qty = Convert.ToInt32(dr["Quantity"]);
                    decimal price = Convert.ToDecimal(dr["UnitPrice"]);
                    decimal lineTotal = qty * price;

                    e.Graphics.DrawString(pname, new Font("Arial", 10), Brushes.Black, 60, y);
                    e.Graphics.DrawString(qty.ToString(), new Font("Arial", 10), Brushes.Black, 250, y);
                    e.Graphics.DrawString(price.ToString("0.00"), new Font("Arial", 10), Brushes.Black, 350, y);
                    e.Graphics.DrawString(lineTotal.ToString("0.00"), new Font("Arial", 10), Brushes.Black, 450, y);
                    y += 20;
                }
                dr.Close();

                y += 20;
                e.Graphics.DrawLine(Pens.Black, 50, y, 750, y);
                y += 30;
                e.Graphics.DrawString("Grand Total: $" + total.ToString("0.00"), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 400, y);
                y += 40;
                e.Graphics.DrawString("Thank you for shopping with us!", new Font("Arial", 10, FontStyle.Italic), Brushes.Black, 250, y);
            }
        }
    }
}
