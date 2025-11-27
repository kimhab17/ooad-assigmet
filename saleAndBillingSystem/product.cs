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
    public partial class product : UserControl
    {
        public product()
        {
            InitializeComponent();
            LoadProducts();
            LoadCategories();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                string query = @"
            SELECT 
                p.ProductID,
                p.ProductName,
                p.Price,
                p.Quantity,
                c.CategoryName
            FROM Products p
            INNER JOIN Categories c ON p.CategoryID = c.CategoryID";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
        }

        private void LoadCategories()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                string query = "SELECT CategoryID, CategoryName FROM Categories";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCategory.DisplayMember = "CategoryName";  // អ្វីដែលបង្ហាញ
                cmbCategory.ValueMember = "CategoryID";      // តម្លៃពិត (ID)
                cmbCategory.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
           
        {
            int categoryID = int.Parse(cmbCategory.SelectedValue.ToString());
            using (SqlConnection conn = Database.GetConnection())
            {
                string query = "INSERT INTO Products(ProductName, Price, Quantity, CategoryID) VALUES(@name, @price, @qty, @cat)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                cmd.Parameters.AddWithValue("@qty", int.Parse(txtQuantity.Text));
                cmd.Parameters.AddWithValue("@cat", categoryID);


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Product added successfully!");
                LoadProducts();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductID"].Value);

            using (SqlConnection conn = Database.GetConnection())
            {
                string query = "UPDATE Products SET ProductName=@name, Price=@price, Quantity=@qty WHERE ProductID=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                cmd.Parameters.AddWithValue("@qty", int.Parse(txtQuantity.Text));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Product updated successfully!");
                LoadProducts();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductID"].Value);

            DialogResult result = MessageBox.Show("Are you sure to delete this product?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    string query = "DELETE FROM Products WHERE ProductID=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Product deleted!");
                    LoadProducts();
                }
            }
        }
        private void dgvProducts_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
            txtProductName.Text = row.Cells["ProductName"].Value.ToString();
            txtPrice.Text = row.Cells["Price"].Value.ToString();
            txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            using (SqlConnection conn = Database.GetConnection())
            {
                // ✅ Use LIKE to find partial matches by ProductName or CategoryName
                string query = @"
        SELECT 
            p.ProductID,
            p.ProductName,
            p.Price,
            p.Quantity,
            c.CategoryName
        FROM Products p
        INNER JOIN Categories c ON p.CategoryID = c.CategoryID
        WHERE p.ProductName LIKE @keyword OR c.CategoryName LIKE @keyword";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgvProducts.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No products found for your search.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvProducts.DataSource = null; // clear the table if no data
                }
            }
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }
    }
}
