namespace TechGear17
{
    partial class UpdateStatusDialog
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
            label4 = new Label();
            cmbStatus = new ComboBox();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(174, 53);
            label4.Name = "label4";
            label4.Size = new Size(243, 45);
            label4.TabIndex = 3;
            label4.Text = "Change Status";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Waiting", "In Process", "Done" });
            cmbStatus.Location = new Point(174, 128);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(261, 40);
            cmbStatus.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 255, 128);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(25, 294);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(186, 47);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSeaGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(370, 294);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(186, 47);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // UpdateStatusDialog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(579, 353);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(label4);
            Controls.Add(cmbStatus);
            Name = "UpdateStatusDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Status";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private ComboBox cmbStatus;
        private Button btnCancel;
        private Button btnSave;
    }
}