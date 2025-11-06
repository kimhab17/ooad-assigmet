using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saleAndBillingSystem
{
    public partial class CashierForm : Form
    {
        private string cashierName;
        public CashierForm(loginForm loginForm)
        {
            InitializeComponent();
            LoadProducts();
            this.Load += CashierForm_Load;
            cashierName = loginForm.LoggedInCashier; // ទាញឈ្មោះ cashier
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
    }
}
