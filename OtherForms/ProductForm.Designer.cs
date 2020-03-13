namespace VolodCodeFirstEF.OtherForms
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.radioButtonInsert = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate = new System.Windows.Forms.RadioButton();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.buttonOk = new System.Windows.Forms.Button();
            this.bindingSourceProducts = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.Size = new System.Drawing.Size(260, 131);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Name :";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(12, 175);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Price :";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(12, 201);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Category :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(118, 149);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(154, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(118, 175);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(154, 20);
            this.textBoxPrice.TabIndex = 5;
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(118, 200);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(154, 21);
            this.comboBoxCategories.TabIndex = 6;
            // 
            // radioButtonInsert
            // 
            this.radioButtonInsert.AutoSize = true;
            this.radioButtonInsert.Checked = true;
            this.radioButtonInsert.Location = new System.Drawing.Point(93, 227);
            this.radioButtonInsert.Name = "radioButtonInsert";
            this.radioButtonInsert.Size = new System.Drawing.Size(51, 17);
            this.radioButtonInsert.TabIndex = 7;
            this.radioButtonInsert.TabStop = true;
            this.radioButtonInsert.Text = "Insert";
            this.radioButtonInsert.UseVisualStyleBackColor = true;
            this.radioButtonInsert.CheckedChanged += new System.EventHandler(this.SelectOperation);
            // 
            // radioButtonUpdate
            // 
            this.radioButtonUpdate.AutoSize = true;
            this.radioButtonUpdate.Location = new System.Drawing.Point(150, 227);
            this.radioButtonUpdate.Name = "radioButtonUpdate";
            this.radioButtonUpdate.Size = new System.Drawing.Size(60, 17);
            this.radioButtonUpdate.TabIndex = 8;
            this.radioButtonUpdate.Text = "Update";
            this.radioButtonUpdate.UseVisualStyleBackColor = true;
            this.radioButtonUpdate.CheckedChanged += new System.EventHandler(this.SelectOperation);
            // 
            // radioButtonDelete
            // 
            this.radioButtonDelete.AutoSize = true;
            this.radioButtonDelete.Location = new System.Drawing.Point(216, 227);
            this.radioButtonDelete.Name = "radioButtonDelete";
            this.radioButtonDelete.Size = new System.Drawing.Size(56, 17);
            this.radioButtonDelete.TabIndex = 9;
            this.radioButtonDelete.Text = "Delete";
            this.radioButtonDelete.UseVisualStyleBackColor = true;
            this.radioButtonDelete.CheckedChanged += new System.EventHandler(this.SelectOperation);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 224);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.radioButtonDelete);
            this.Controls.Add(this.radioButtonUpdate);
            this.Controls.Add(this.radioButtonInsert);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewProducts);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.RadioButton radioButtonInsert;
        private System.Windows.Forms.RadioButton radioButtonUpdate;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.BindingSource bindingSourceProducts;
    }
}