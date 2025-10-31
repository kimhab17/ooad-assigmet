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
    public partial class dashboard : UserControl
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }
        private void LoadDashboardData()
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    // 🔹 Total Products
                    SqlCommand cmdProducts = new SqlCommand("SELECT COUNT(*) FROM Products", conn);
                    lbProduct.Text = cmdProducts.ExecuteScalar().ToString();

                    // 🔹 Total Users
                    //SqlCommand cmdUsers = new SqlCommand("SELECT COUNT(*) FROM Users", conn);
                    //lblTotalUsers.Text = cmdUsers.ExecuteScalar().ToString();

                    //// 🔹 Total Sales Today
                    //SqlCommand cmdSales = new SqlCommand("SELECT COUNT(*) FROM Sales WHERE CAST(SaleDate AS DATE) = CAST(GETDATE() AS DATE)", conn);
                    //lblSalesToday.Text = cmdSales.ExecuteScalar().ToString();

                    //// 🔹 Total Income
                    //SqlCommand cmdIncome = new SqlCommand("SELECT ISNULL(SUM(TotalAmount), 0) FROM Sales", conn);
                    //lblTotalIncome.Text = "$" + cmdIncome.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message);
            }
        }
    }
}
