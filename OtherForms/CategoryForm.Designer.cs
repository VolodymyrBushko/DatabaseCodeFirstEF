namespace VolodCodeFirstEF.OtherForms
{
    partial class CategoryForm
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate = new System.Windows.Forms.RadioButton();
            this.radioButtonInsert = new System.Windows.Forms.RadioButton();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.bindingSourceCategories = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 225);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 21;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // radioButtonDelete
            // 
            this.radioButtonDelete.AutoSize = true;
            this.radioButtonDelete.Location = new System.Drawing.Point(216, 228);
            this.radioButtonDelete.Name = "radioButtonDelete";
            this.radioButtonDelete.Size = new System.Drawing.Size(56, 17);
            this.radioButtonDelete.TabIndex = 20;
            this.radioButtonDelete.Text = "Delete";
            this.radioButtonDelete.UseVisualStyleBackColor = true;
            this.radioButtonDelete.CheckedChanged += new System.EventHandler(this.SelectOperations);
            // 
            // radioButtonUpdate
            // 
            this.radioButtonUpdate.AutoSize = true;
            this.radioButtonUpdate.Location = new System.Drawing.Point(150, 228);
            this.radioButtonUpdate.Name = "radioButtonUpdate";
            this.radioButtonUpdate.Size = new System.Drawing.Size(60, 17);
            this.radioButtonUpdate.TabIndex = 19;
            this.radioButtonUpdate.Text = "Update";
            this.radioButtonUpdate.UseVisualStyleBackColor = true;
            this.radioButtonUpdate.CheckedChanged += new System.EventHandler(this.SelectOperations);
            // 
            // radioButtonInsert
            // 
            this.radioButtonInsert.AutoSize = true;
            this.radioButtonInsert.Checked = true;
            this.radioButtonInsert.Location = new System.Drawing.Point(93, 228);
            this.radioButtonInsert.Name = "radioButtonInsert";
            this.radioButtonInsert.Size = new System.Drawing.Size(51, 17);
            this.radioButtonInsert.TabIndex = 18;
            this.radioButtonInsert.TabStop = true;
            this.radioButtonInsert.Text = "Insert";
            this.radioButtonInsert.UseVisualStyleBackColor = true;
            this.radioButtonInsert.CheckedChanged += new System.EventHandler(this.SelectOperations);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(118, 202);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(154, 20);
            this.textBoxName.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 202);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Name :";
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Location = new System.Drawing.Point(12, 13);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.ReadOnly = true;
            this.dataGridViewCategories.Size = new System.Drawing.Size(260, 183);
            this.dataGridViewCategories.TabIndex = 11;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.radioButtonDelete);
            this.Controls.Add(this.radioButtonUpdate);
            this.Controls.Add(this.radioButtonInsert);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewCategories);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.RadioButton radioButtonUpdate;
        private System.Windows.Forms.RadioButton radioButtonInsert;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.BindingSource bindingSourceCategories;
    }
}