namespace TechGear17
{
    partial class ServiceUC
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
            panel2 = new Panel();
            txtProblem = new RichTextBox();
            btnClear = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label2 = new Label();
            label3 = new Label();
            txtPhone = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateBlue;
            panel2.Controls.Add(txtProblem);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtName);
            panel2.Location = new Point(37, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 767);
            panel2.TabIndex = 2;
            // 
            // txtProblem
            // 
            txtProblem.Location = new Point(17, 132);
            txtProblem.Name = "txtProblem";
            txtProblem.Size = new Size(326, 288);
            txtProblem.TabIndex = 4;
            txtProblem.Text = "";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SlateBlue;
            btnClear.FlatAppearance.BorderColor = Color.MediumOrchid;
            btnClear.FlatAppearance.BorderSize = 3;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(20, 687);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(323, 60);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SlateBlue;
            btnUpdate.FlatAppearance.BorderColor = Color.MediumOrchid;
            btnUpdate.FlatAppearance.BorderSize = 3;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(20, 621);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(323, 60);
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
            btnAdd.Location = new Point(20, 555);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(323, 60);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 101);
            label2.Name = "label2";
            label2.Size = new Size(154, 28);
            label2.TabIndex = 2;
            label2.Text = "Type of Damage";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 457);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(17, 484);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Optional";
            txtPhone.Size = new Size(326, 37);
            txtPhone.TabIndex = 0;
            txtPhone.Tag = "optional";
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 25);
            label1.Name = "label1";
            label1.Size = new Size(153, 28);
            label1.TabIndex = 2;
            label1.Text = "Customer Name";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(17, 52);
            txtName.Name = "txtName";
            txtName.Size = new Size(326, 37);
            txtName.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(438, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 767);
            panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(717, 767);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick_1;
            // 
            // ServiceUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "ServiceUC";
            Size = new Size(1184, 826);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private RichTextBox txtProblem;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label2;
        private Label label3;
        private TextBox txtPhone;
        private Label label1;
        private TextBox txtName;
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}
