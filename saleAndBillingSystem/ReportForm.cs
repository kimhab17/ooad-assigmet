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
//using System.Data.DataTable;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing.Printing;
//using DrawingFont = System.Drawing.Font;

namespace saleAndBillingSystem
{
    public partial class ReportForm : UserControl
    {
        PrintDocument printDoc = new PrintDocument();
        PrintPreviewDialog previewDialog = new PrintPreviewDialog();
        int currentRow = 0;
        int yPos = 0;
        public ReportForm()
        {
            InitializeComponent();
            printDoc.PrintPage += PrintPageHandler;
        }
        private void LoadReport(DateTime startDate, DateTime endDate)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                string query = @"
            SELECT 
                s.SaleID,
                s.CashierName,
                s.SaleDate,
                s.TotalAmount
            FROM Sales s
            WHERE s.SaleDate BETWEEN @start AND @end
            ORDER BY s.SaleDate DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@start", startDate);
                cmd.Parameters.AddWithValue("@end", endDate);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);

                dgvReport.DataSource = dt;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadReport(dtStart.Value, dtEnd.Value);
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            int startX = 50;   // ចំណុចចាប់ផ្តើមបោះពុម្ពផ្នែកឆ្វេង
            int startY = 120;  // ចំណុចចាប់ផ្តើមបោះពុម្ពខាងលើ
            int offsetY = 0;   // ចម្ងាយរវាងបន្ទាត់
            System.Drawing.Font font = new System.Drawing.Font("Arial", 10);
            Brush brush = Brushes.Black;

            // 🏷️ បោះពុម្ព Header
            e.Graphics.DrawString("🧾 Sales Report", new System.Drawing.Font("Arial", 16, FontStyle.Bold), brush, startX + 200, 40);
            e.Graphics.DrawString($"Date: {DateTime.Now.ToShortDateString()}", font, brush, startX, 80);

            // 📦 បោះពុម្ព Header Columns
            for (int i = 0; i < dgvReport.Columns.Count; i++)
            {
                e.Graphics.DrawString(dgvReport.Columns[i].HeaderText, font, brush, startX + (i * 120), startY);
            }

            offsetY = 30;
            yPos = startY + offsetY;

            // 🔁 បោះពុម្ព Data Rows
            while (currentRow < dgvReport.Rows.Count)
            {
                DataGridViewRow row = dgvReport.Rows[currentRow];
                for (int i = 0; i < dgvReport.Columns.Count; i++)
                {
                    e.Graphics.DrawString(row.Cells[i].Value?.ToString(), font, brush, startX + (i * 120), yPos);
                }

                yPos += 25;
                currentRow++;

                // បើទំព័រមិនទាន់អស់ → បន្តទំព័រថ្មី
                if (yPos >= e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            // បោះពុម្ព Total Amount នៅខាងក្រោម
            e.Graphics.DrawString("Total Amount: " + CalculateTotal(), new System.Drawing.Font("Arial", 12, FontStyle.Bold), brush, startX, yPos + 40);

            // បន្ថែមកន្លែងសម្រាប់ហត្ថលេខា
            e.Graphics.DrawString("Signature: ______________________", font, brush, startX + 400, yPos + 80);

            e.HasMorePages = false;
            currentRow = 0;
        }

        private decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvReport.Rows)
            {
                if (row.Cells["TotalAmount"].Value != null)
                    total += Convert.ToDecimal(row.Cells["TotalAmount"].Value);
            }
            return total;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Workbooks.Add(Type.Missing);
                Excel._Worksheet worksheet = (Excel._Worksheet)excelApp.ActiveSheet;

                // Export Header
                for (int i = 1; i <= dgvReport.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = dgvReport.Columns[i - 1].HeaderText;
                }

                // Export Data Rows
                for (int i = 0; i < dgvReport.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvReport.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvReport.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                // Save File Dialog
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save Sales Report";
                saveFileDialog.FileName = "SalesReport_" + DateTime.Now.ToString("yyyyMMdd") + ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    worksheet.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Exported Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                excelApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            previewDialog.Document = printDoc;
            previewDialog.Width = 800;
            previewDialog.Height = 600;
            previewDialog.ShowDialog();
        }
    }
}
