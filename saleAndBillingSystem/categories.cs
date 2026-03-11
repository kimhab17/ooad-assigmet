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
        private CategoryRepository _repository;

        public categories()
        {
            InitializeComponent();
            _repository = new CategoryRepository();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;
            LoadCategories();
        }

        private void LoadCategories()
        {
            dgvCategories.DataSource = _repository.GetAllCategories();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter category name!");
                return;
            }

            _repository.AddCategory(txtCategoryName.Text.Trim());

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

            _repository.UpdateCategory(id, txtCategoryName.Text.Trim());

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
                _repository.DeleteCategory(id);

                MessageBox.Show("Category deleted successfully!");
                txtCategoryName.Clear();
                LoadCategories();
            }
        }
    }
}
