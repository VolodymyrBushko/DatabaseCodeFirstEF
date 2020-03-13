using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VolodCodeFirstEF.Database;

namespace VolodCodeFirstEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            using (MyModel context = new MyModel())
            {
                bindingSource1.DataSource =
                    context.Products.Include("Category").Select(p => new
                    {
                        ProductName = p.Name,
                        ProductPrice = p.Price,
                        CategoryName = p.Category.Name
                    }).ToArray();
                dataGridView1.DataSource = bindingSource1;
            }
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtherForms.ProductForm productForm = new OtherForms.ProductForm();
            productForm.ShowDialog();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtherForms.CategoryForm categoryForm = new OtherForms.CategoryForm();
            categoryForm.ShowDialog();
        }
    }
}