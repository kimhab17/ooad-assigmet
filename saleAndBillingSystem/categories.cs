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
    public partial class categories : UserControl
    {
        public categories()
        {
            InitializeComponent();
            LoadCategories();


        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                string query = "SELECT * FROM Categories ORDER BY CategoryID DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCategories.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter category name!");
                return;
            }

            using (SqlConnection conn = Database.GetConnection())
            {
                string query = "INSERT INTO Categories (CategoryName) VALUES (@name)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", txtCategoryName.Text.Trim());
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Category added successfully!");
            txtCategoryName.Clear();
            LoadCategories();
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtCategoryName.Text = dgvCategories.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvCategories.CurrentRow.Cells["CategoryID"].Value);

            using (SqlConnection conn = Database.GetConnection())
            {
                string query = "UPDATE Categories SET CategoryName=@name WHERE CategoryID=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", txtCategoryName.Text.Trim());
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Category updated successfully!");
            txtCategoryName.Clear();
            LoadCategories();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvCategories.CurrentRow.Cells["CategoryID"].Value);

            DialogResult confirm = MessageBox.Show("Do you want to delete this category?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    string query = "DELETE FROM Categories WHERE CategoryID=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Category deleted successfully!");
                txtCategoryName.Clear();
                LoadCategories();
            }
        }
    }
}
