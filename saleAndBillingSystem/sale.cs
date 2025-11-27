using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace saleAndBillingSystem
{
    public partial class sale : UserControl
    {
        public sale()
        {
            InitializeComponent();
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Load += Sale_Load; // ✅ ensure Load event fires
            btnFilter.Click += btnFilter_Click; // ✅ attach button event
            dgvSales.CellClick += dgvSales_CellClick; // ✅ attach grid click event
        }

        // ✅ Load event handler
        private void Sale_Load(object sender, EventArgs e)
        {
            // Set default filter dates to today
            dtFrom.Value = DateTime.Today;
            dtTo.Value = DateTime.Today;

            // Load data
            LoadSales();
            CalculateTotalSales();
        }

        // ✅ Load all sales from database
        private void LoadSales()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                string query = "SELECT * FROM Sales ORDER BY SaleDate DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSales.DataSource = dt;
            }
        }

        // ✅ When a sale row is clicked, load its detail
        private void dgvSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Get the SaleID from the clicked row
            int saleID = Convert.ToInt32(dgvSales.Rows[e.RowIndex].Cells["SaleID"].Value);
            LoadSaleDetails(saleID);
        }

        private void LoadSaleDetails(int saleID)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                string query = "SELECT ProductName, UnitPrice, Quantity, UnitPrice, SubTotal FROM SaleDetails WHERE SaleID=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", saleID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSaleDetails.DataSource = dt;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                string query = "SELECT * FROM Sales WHERE SaleDate BETWEEN @from AND @to ORDER BY SaleDate DESC";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@from", dtFrom.Value.Date);
                cmd.Parameters.AddWithValue("@to", dtTo.Value.Date.AddDays(1).AddTicks(-1));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSales.DataSource = dt;
            }

            CalculateTotalSales();
        }

        private void CalculateTotalSales()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                if (row.Cells["TotalAmount"].Value != null &&
                    decimal.TryParse(row.Cells["TotalAmount"].Value.ToString(), out decimal amount))
                {
                    total += amount;
                }
            }

            lblTotalSales.Text = $"Total Sales: ${total:F2}";

            // Optional: Make it look nice
            if (total > 0)
            {
                lblTotalSales.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblTotalSales.ForeColor = System.Drawing.Color.Red;
            }
        }

    }
}
