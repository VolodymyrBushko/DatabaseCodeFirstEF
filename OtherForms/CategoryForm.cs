using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VolodCodeFirstEF.Database;

namespace VolodCodeFirstEF.OtherForms
{
    public partial class CategoryForm : Form
    {
        private enum Operation
        {
            Insert = 1,
            Update,
            Delete
        };

        private Operation LastOperation;

        public CategoryForm()
        {
            InitializeComponent();
            InitializeDataGridViewCategories();

            buttonOk.Click += Insert;
            LastOperation = Operation.Insert;
        }

        private void InitializeDataGridViewCategories()
        {
            using (MyModel context = new MyModel())
            {
                bindingSourceCategories.DataSource =
                    context.Categories.Select(c => new
                    {
                        Id = c.Id,
                        Name = c.Name
                    }).ToArray();
                dataGridViewCategories.DataSource = bindingSourceCategories;
            }
        }

        private void SelectOperations(object sender, EventArgs e)
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
            using (MyModel context = new MyModel())
            {
                if (!string.IsNullOrWhiteSpace(textBoxName.Text))
                {
                    Category category = new Category()
                    {
                        Name = textBoxName.Text
                    };
                    context.Categories.Add(category);
                    context.SaveChanges();

                    this.textBoxName.Clear();
                    InitializeDataGridViewCategories();
                }
            }
        }

        private void Update(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxName.Text))
                {
                    using (MyModel context = new MyModel())
                    {
                        int id = Convert.ToInt32(dataGridViewCategories.SelectedRows[0].Cells["Id"].Value);
                        Category category = context.Categories.FirstOrDefault(c => c.Id == id);
                        if (category != null)
                        {
                            category.Name = textBoxName.Text;
                            context.SaveChanges();

                            textBoxName.Clear();
                            InitializeDataGridViewCategories();
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
                    int id = Convert.ToInt32(dataGridViewCategories.SelectedRows[0].Cells["Id"].Value);
                    Category category = context.Categories.FirstOrDefault(c => c.Id == id);
                    if (category != null)
                    {
                        context.Categories.Remove(category);
                        context.SaveChanges();

                        textBoxName.Clear();
                        InitializeDataGridViewCategories();
                    }
                }
            }
            catch { }
        }
    }
}
