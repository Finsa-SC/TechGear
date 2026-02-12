namespace TechGear17
{
    partial class ServiceDetailDialog
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvItem = new DataGridView();
            dgvDetail = new DataGridView();
            txtSearch = new TextBox();
            cmbSCategory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            SuspendLayout();
            // 
            // dgvItem
            // 
            dgvItem.AllowUserToAddRows = false;
            dgvItem.AllowUserToDeleteRows = false;
            dgvItem.AllowUserToResizeColumns = false;
            dgvItem.AllowUserToResizeRows = false;
            dgvItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItem.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvItem.DefaultCellStyle = dataGridViewCellStyle2;
            dgvItem.EnableHeadersVisualStyles = false;
            dgvItem.Location = new Point(12, 102);
            dgvItem.MultiSelect = false;
            dgvItem.Name = "dgvItem";
            dgvItem.ReadOnly = true;
            dgvItem.RowHeadersVisible = false;
            dgvItem.RowHeadersWidth = 62;
            dgvItem.Size = new Size(743, 561);
            dgvItem.TabIndex = 1;
            dgvItem.CellContentClick += dgvItem_CellContentClick;
            // 
            // dgvDetail
            // 
            dgvDetail.AllowUserToAddRows = false;
            dgvDetail.AllowUserToDeleteRows = false;
            dgvDetail.AllowUserToResizeColumns = false;
            dgvDetail.AllowUserToResizeRows = false;
            dgvDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetail.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvDetail.DefaultCellStyle = dataGridViewCellStyle4;
            dgvDetail.EnableHeadersVisualStyles = false;
            dgvDetail.Location = new Point(761, 39);
            dgvDetail.MultiSelect = false;
            dgvDetail.Name = "dgvDetail";
            dgvDetail.ReadOnly = true;
            dgvDetail.RowHeadersVisible = false;
            dgvDetail.RowHeadersWidth = 62;
            dgvDetail.Size = new Size(627, 624);
            dgvDetail.TabIndex = 1;
            dgvDetail.CellContentClick += dgvDetail_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(238, 39);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "  Search...";
            txtSearch.Size = new Size(389, 37);
            txtSearch.TabIndex = 5;
            txtSearch.Tag = "noreset, optional";
            // 
            // cmbSCategory
            // 
            cmbSCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSCategory.FlatStyle = FlatStyle.System;
            cmbSCategory.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSCategory.FormattingEnabled = true;
            cmbSCategory.Location = new Point(15, 39);
            cmbSCategory.Name = "cmbSCategory";
            cmbSCategory.Size = new Size(217, 38);
            cmbSCategory.TabIndex = 4;
            cmbSCategory.Tag = "noreset";
            // 
            // ServiceDetailDialog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 690);
            Controls.Add(txtSearch);
            Controls.Add(cmbSCategory);
            Controls.Add(dgvDetail);
            Controls.Add(dgvItem);
            Name = "ServiceDetailDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ServiceDetailDialog";
            ((System.ComponentModel.ISupportInitialize)dgvItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvItem;
        private DataGridView dgvDetail;
        private TextBox txtSearch;
        private ComboBox cmbSCategory;
    }
}