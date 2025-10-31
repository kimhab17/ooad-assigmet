using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace saleAndBillingSystem
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)

        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT UserRole FROM Users WHERE Username=@user AND Pass=@pass";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader["UserRole"].ToString();

                    MessageBox.Show("Role from database: " + role);

                    if (role.Trim().Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        AdminForm admin = new AdminForm();
                        admin.FormClosed += (s, args) => this.Show();
                        admin.Show();
                        this.Hide();
                    }
                    else if (role.Trim().Equals("Cashier", StringComparison.OrdinalIgnoreCase))
                    {
                        CashierForm cashier = new CashierForm();
                        cashier.FormClosed += (s, args) => this.Show();
                        cashier.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
            }
        }
    }
}
