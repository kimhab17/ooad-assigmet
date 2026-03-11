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

        public string LoggedInCashier { get; private set; }

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

                    if (role.Trim().Equals("Admin", StringComparison.OrdinalIgnoreCase) || role.Trim().Equals("Cashier", StringComparison.OrdinalIgnoreCase))
                    {
                        if (role.Trim().Equals("Cashier", StringComparison.OrdinalIgnoreCase))
                        {
                            LoggedInCashier = txtUsername.Text;
                        }

                        Form mainForm = FormFactory.CreateMainForm(role, this);
                        mainForm.FormClosed += (s, args) => this.Show();
                        mainForm.Show();
                        this.Hide();

                        
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to close the program?",
        "Exit Application",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
    );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
