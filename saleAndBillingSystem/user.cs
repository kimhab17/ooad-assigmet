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
    public partial class user : UserControl
    {
        public user()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.userForm_Load);
            LoadUsers();
        }

        private void userForm_Load(object sender, EventArgs e)
        {
            if (cmbRole.Items.Count == 0)
            {
                cmbRole.Items.Add("Admin");
                cmbRole.Items.Add("Cashier");
            }
        }
        private void LoadUsers()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUsers.DataSource = dt;
            }
        }
        private void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || cmbRole.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            string role = cmbRole.SelectedItem.ToString();

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username, Pass, UserRole) VALUES (@u, @p, @r)", conn);
                cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                cmd.Parameters.AddWithValue("@p", txtPassword.Text);
                cmd.Parameters.AddWithValue("@r", role);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User added successfully!");
            }

            LoadUsers();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Select a user to update!");
                return;
            }

            int id = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Users SET Username=@u, Pass=@p, UserRole=@r WHERE UserID=@id", conn);
                cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                cmd.Parameters.AddWithValue("@p", txtPassword.Text);
                cmd.Parameters.AddWithValue("@r", cmbRole.Text);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User updated successfully!");
            }

            LoadUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);
            DialogResult result = MessageBox.Show("Are you sure to delete this user?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE UserID=@id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User deleted successfully!");
                }

                LoadUsers();
                ClearFields();
            }
        }

        private void dgvUsers_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure a valid row is clicked
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Text = row.Cells["Pass"].Value.ToString();

                string role = row.Cells["UserRole"].Value.ToString();

                // Set ComboBox SelectedItem properly
                if (cmbRole.Items.Contains(role))
                {
                    cmbRole.SelectedItem = role;
                }
                else
                {
                    cmbRole.SelectedIndex = -1; // Clear selection if role not in ComboBox
                }
            }
        }
    }
}
