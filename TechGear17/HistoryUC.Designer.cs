namespace TechGear17
{
    partial class HistoryUC
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvHistory = new DataGridView();
            txtSearch = new TextBox();
            dteSearch = new DateTimePicker();
            dgvDetail = new DataGridView();
            label1 = new Label();
            dteIn = new DateTimePicker();
            cmbStatus = new ComboBox();
            txtDamage = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            SuspendLayout();
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AllowUserToResizeColumns = false;
            dgvHistory.AllowUserToResizeRows = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHistory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHistory.EnableHeadersVisualStyles = false;
            dgvHistory.Location = new Point(32, 99);
            dgvHistory.MultiSelect = false;
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.RowHeadersWidth = 62;
            dgvHistory.Size = new Size(1359, 346);
            dgvHistory.TabIndex = 2;
            dgvHistory.CellContentDoubleClick += dgvHistory_CellContentDoubleClick;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(284, 34);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "  Search...";
            txtSearch.Size = new Size(389, 37);
            txtSearch.TabIndex = 7;
            txtSearch.Tag = "noreset, optional";
            // 
            // dteSearch
            // 
            dteSearch.CustomFormat = "dd-MMMM-yyyy";
            dteSearch.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dteSearch.Format = DateTimePickerFormat.Custom;
            dteSearch.Location = new Point(32, 34);
            dteSearch.Name = "dteSearch";
            dteSearch.Size = new Size(231, 37);
            dteSearch.TabIndex = 8;
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
            dgvDetail.Location = new Point(32, 477);
            dgvDetail.MultiSelect = false;
            dgvDetail.Name = "dgvDetail";
            dgvDetail.ReadOnly = true;
            dgvDetail.RowHeadersVisible = false;
            dgvDetail.RowHeadersWidth = 62;
            dgvDetail.Size = new Size(811, 325);
            dgvDetail.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(875, 477);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 10;
            label1.Text = "Type Of Damage";
            // 
            // dteIn
            // 
            dteIn.CustomFormat = "dd MMMM yyyy";
            dteIn.Enabled = false;
            dteIn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dteIn.Format = DateTimePickerFormat.Custom;
            dteIn.Location = new Point(865, 765);
            dteIn.Name = "dteIn";
            dteIn.Size = new Size(300, 37);
            dteIn.TabIndex = 11;
            // 
            // cmbStatus
            // 
            cmbStatus.Enabled = false;
            cmbStatus.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Waiting", "In Process", "Done" });
            cmbStatus.Location = new Point(865, 680);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(300, 38);
            cmbStatus.TabIndex = 12;
            // 
            // txtDamage
            // 
            txtDamage.BorderStyle = BorderStyle.FixedSingle;
            txtDamage.Enabled = false;
            txtDamage.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDamage.Location = new Point(865, 502);
            txtDamage.Name = "txtDamage";
            txtDamage.Size = new Size(300, 136);
            txtDamage.TabIndex = 13;
            txtDamage.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(875, 655);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 10;
            label2.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(875, 738);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 10;
            label3.Text = "Date Entry";
            // 
            // HistoryUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtDamage);
            Controls.Add(cmbStatus);
            Controls.Add(dteIn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dteSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvDetail);
            Controls.Add(dgvHistory);
            Name = "HistoryUC";
            Size = new Size(1184, 826);
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistory;
        private TextBox txtSearch;
        private DateTimePicker dteSearch;
        private DataGridView dgvDetail;
        private Label label1;
        private DateTimePicker dteIn;
        private ComboBox cmbStatus;
        private RichTextBox txtDamage;
        private Label label2;
        private Label label3;
    }
}
