using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VolodCodeFirstEF.Database;

namespace VolodCodeFirstEF.OtherForms
{
    public partial class ProductForm : Form
    {
        private enum Operation
        {
            Insert = 1,
            Update,
            Delete
        };

        private Operation LastOperation;

        public ProductForm()
        {
            InitializeComponent();
            InitializeDataGridViewProducts();
            InitializeComboBoxCategories();

            buttonOk.Click += Insert;
            LastOperation = Operation.Insert;
        }

        private void InitializeDataGridViewProducts()
        {
            using (MyModel context = new MyModel())
            {
                bindingSourceProducts.DataSource =
                    context.Products.Select(p => new
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Price = p.Price,
                        Category = context.Categories.FirstOrDefault(c => c.Id == p.CategoryId)
                    }).ToArray();
                dataGridViewProducts.DataSource = bindingSourceProducts;
            }
        }

        private void InitializeComboBoxCategories()
        {
            using (MyModel context = new MyModel())
            {
                comboBoxCategories.Items.AddRange(context.Categories.ToArray());
            }
        }

        private void SelectOperation(object sender, EventArgs e)
        {
            switch (LastOperation)
            {
                case Operation.Insert: buttonOk.Click -= Insert; break;
                case Operation.Update: buttonOk.Click -= Update; break;
                case Operation.Delete: buttonOk.Click -= Delete; break;
            }

            switch ((sender as RadioButton).Name)
            {
                case "radioButtonInsert": buttonOk.Click += Insert; LastOperation = Operation.Insert; break;
                case "radioButtonUpdate": buttonOk.Click += Update; LastOperation = Operation.Update; break;
                case "radioButtonDelete": buttonOk.Click += Delete; LastOperation = Operation.Delete; break;
            }
        }

        private void Insert(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxName.Text) &&
                    !string.IsNullOrWhiteSpace(textBoxPrice.Text) &&
                    !string.IsNullOrWhiteSpace(comboBoxCategories.Text))
                {
                    using (MyModel context = new MyModel())
                    {
                        Product product = new Product()
                        {
                            Name = textBoxName.Text,
                            Price = Convert.ToInt32(textBoxPrice.Text),
                            CategoryId = (comboBoxCategories.SelectedItem as Category).Id
                        };
                        context.Products.Add(product);
                        context.SaveChanges();

                        textBoxName.Clear();
                        textBoxPrice.Clear();
                        comboBoxCategories.Text = string.Empty;
                        InitializeDataGridViewProducts();
                    }
                }
            }
            catch { }
        }

        private void Update(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxName.Text) &&
                    !string.IsNullOrWhiteSpace(textBoxPrice.Text) &&
                    !string.IsNullOrWhiteSpace(comboBoxCategories.Text))
                {
                    using (MyModel context = new MyModel())
                    {
                        int id = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells["Id"].Value);
                        Product product = context.Products.FirstOrDefault(p => p.Id == id);
                        if (product != null)
                        {
                            product.Name = textBoxName.Text;
                            product.Price = Convert.ToInt32(textBoxPrice.Text);
                            product.CategoryId = (comboBoxCategories.SelectedItem as Category).Id;

                            context.SaveChanges();

                            textBoxName.Clear();
                            textBoxPrice.Clear();
                            comboBoxCategories.Text = string.Empty;
                            InitializeDataGridViewProducts();
                        }
                    }
                }
            }
            catch { MessageBox.Show("Selected row == null"); }
        }

        private void Delete(object sender, EventArgs e)
        {
            try
            {
                using (MyModel context = new MyModel())
                {
                    int id = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells["Id"].Value);
                    Product product = context.Products.FirstOrDefault(p => p.Id == id);
                    if (product != null)
                    {
                        context.Products.Remove(product);
                        context.SaveChanges();

                        InitializeDataGridViewProducts();
                    }
                }
            }
            catch { MessageBox.Show("Selected row == null"); }
        }
    }
}