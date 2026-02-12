namespace TechGear17
{
    partial class ItemManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            cmbCategory = new ComboBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            txtName = new TextBox();
            cmbSCategory = new ComboBox();
            txtSearch = new TextBox();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(383, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(771, 699);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(771, 699);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateBlue;
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cmbCategory);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(txtStock);
            panel2.Controls.Add(txtName);
            panel2.Location = new Point(30, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 767);
            panel2.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SlateBlue;
            btnClear.FlatAppearance.BorderColor = Color.MediumOrchid;
            btnClear.FlatAppearance.BorderSize = 3;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(164, 692);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(138, 60);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SlateBlue;
            btnDelete.FlatAppearance.BorderColor = Color.MediumOrchid;
            btnDelete.FlatAppearance.BorderSize = 3;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(17, 692);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 60);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SlateBlue;
            btnUpdate.FlatAppearance.BorderColor = Color.MediumOrchid;
            btnUpdate.FlatAppearance.BorderSize = 3;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(164, 626);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(138, 60);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SlateBlue;
            btnAdd.FlatAppearance.BorderColor = Color.MediumOrchid;
            btnAdd.FlatAppearance.BorderSize = 3;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(17, 626);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 60);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            btnAdd.MouseHover += btnAdd_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 270);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 2;
            label2.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(17, 437);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 2;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 355);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 2;
            label3.Text = "Stock";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 194);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 2;
            label1.Text = "Item Name";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 11F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(17, 298);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(285, 38);
            cmbCategory.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(17, 464);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(285, 37);
            txtPrice.TabIndex = 0;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // txtStock
            // 
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.Location = new Point(17, 382);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(285, 37);
            txtStock.TabIndex = 0;
            txtStock.KeyPress += txtStock_KeyPress;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(17, 221);
            txtName.Name = "txtName";
            txtName.Size = new Size(285, 37);
            txtName.TabIndex = 0;
            // 
            // cmbSCategory
            // 
            cmbSCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSCategory.FlatStyle = FlatStyle.System;
            cmbSCategory.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSCategory.FormattingEnabled = true;
            cmbSCategory.Location = new Point(383, 28);
            cmbSCategory.Name = "cmbSCategory";
            cmbSCategory.Size = new Size(217, 38);
            cmbSCategory.TabIndex = 2;
            cmbSCategory.Tag = "noreset";
            cmbSCategory.SelectedIndexChanged += cmbSCategory_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(606, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "  Search...";
            txtSearch.Size = new Size(548, 37);
            txtSearch.TabIndex = 3;
            txtSearch.Tag = "noreset, optional";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // ItemManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtSearch);
            Controls.Add(cmbSCategory);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ItemManagement";
            Size = new Size(1184, 826);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private ComboBox cmbSCategory;
        private TextBox txtSearch;
        private TextBox txtName;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label1;
        private ComboBox cmbCategory;
        private TextBox txtPrice;
        private TextBox txtStock;
        private Button btnAdd;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private ToolTip toolTip1;
    }
}
