using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saleAndBillingSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Admin Dashboard!");
        }

        private void btnDash_MouseClick(object sender, MouseEventArgs e)
        {
            dashboard1.BringToFront();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            user1.BringToFront();
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            product1.BringToFront();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            sale1.BringToFront();
        }

        private void btnCate_Click(object sender, EventArgs e)
        {
            categories1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportForm1.BringToFront();
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
