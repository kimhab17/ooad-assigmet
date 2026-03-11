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


        private void LoadDashboardData()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                SqlCommand cmdProducts = new SqlCommand("SELECT COUNT(*) FROM Products", conn);
                int totalProducts = (int)cmdProducts.ExecuteScalar();
                lblTotalProducts.Text = totalProducts.ToString();

                SqlCommand cmdUsers = new SqlCommand("SELECT COUNT(*) FROM Users", conn);
                int totalUsers = (int)cmdUsers.ExecuteScalar();
                lblTotalUsers.Text = totalUsers.ToString();

                SqlCommand cmdIncome = new SqlCommand("SELECT ISNULL(SUM(TotalAmount),0) FROM Sales", conn);
                decimal totalIncome = Convert.ToDecimal(cmdIncome.ExecuteScalar());
                z.Text = totalIncome.ToString("C"); // Format to currency

                SqlCommand cmdTodaySales = new SqlCommand("SELECT ISNULL(SUM(TotalAmount),0) FROM Sales WHERE CAST(SaleDate AS DATE) = CAST(GETDATE() AS DATE)", conn);
                decimal todaySales = Convert.ToDecimal(cmdTodaySales.ExecuteScalar());
                lblTodaySales.Text = todaySales.ToString("C");

                conn.Close();
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;
            LoadDashboardData();
        }

        private void z_Click(object sender, EventArgs e)
        {

        }
    }
}
