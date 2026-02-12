namespace TechGear17
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnItem = new Button();
            btnService = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lblClock = new Label();
            pnlActivity = new Panel();
            tmrWaktu = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 33, 77);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 894);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnItem);
            flowLayoutPanel1.Controls.Add(btnService);
            flowLayoutPanel1.Controls.Add(btnDashboard);
            flowLayoutPanel1.Location = new Point(-5, 212);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(305, 360);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnDashboard.ForeColor = SystemColors.ControlLightLight;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(6, 191);
            btnDashboard.Margin = new Padding(6, 3, 3, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(299, 85);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "History";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnItem
            // 
            btnItem.FlatAppearance.BorderSize = 0;
            btnItem.FlatStyle = FlatStyle.Flat;
            btnItem.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnItem.ForeColor = SystemColors.ControlLightLight;
            btnItem.Image = (Image)resources.GetObject("btnItem.Image");
            btnItem.ImageAlign = ContentAlignment.MiddleLeft;
            btnItem.Location = new Point(6, 6);
            btnItem.Margin = new Padding(6, 6, 3, 3);
            btnItem.Name = "btnItem";
            btnItem.Size = new Size(299, 85);
            btnItem.TabIndex = 0;
            btnItem.Text = "Items Management";
            btnItem.UseVisualStyleBackColor = true;
            btnItem.Click += btnItem_Click;
            // 
            // btnService
            // 
            btnService.FlatAppearance.BorderSize = 0;
            btnService.FlatStyle = FlatStyle.Flat;
            btnService.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnService.ForeColor = SystemColors.ControlLightLight;
            btnService.Image = (Image)resources.GetObject("btnService.Image");
            btnService.ImageAlign = ContentAlignment.MiddleLeft;
            btnService.Location = new Point(6, 100);
            btnService.Margin = new Padding(6, 6, 3, 3);
            btnService.Name = "btnService";
            btnService.Size = new Size(299, 85);
            btnService.TabIndex = 1;
            btnService.Text = "Service";
            btnService.UseVisualStyleBackColor = true;
            btnService.Click += btnService_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(107, 116);
            label2.Name = "label2";
            label2.Size = new Size(105, 30);
            label2.TabIndex = 2;
            label2.Text = "TechGear";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(110, 68);
            label1.Name = "label1";
            label1.Size = new Size(133, 60);
            label1.TabIndex = 1;
            label1.Text = "Fairy";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(25, 25, 64);
            panel2.Controls.Add(lblClock);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1184, 68);
            panel2.TabIndex = 1;
            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClock.ForeColor = Color.White;
            lblClock.Location = new Point(876, 21);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(73, 30);
            lblClock.TabIndex = 0;
            lblClock.Text = "label3";
            // 
            // pnlActivity
            // 
            pnlActivity.BackColor = Color.FromArgb(58, 58, 105);
            pnlActivity.Dock = DockStyle.Fill;
            pnlActivity.Location = new Point(300, 68);
            pnlActivity.Name = "pnlActivity";
            pnlActivity.Size = new Size(1184, 826);
            pnlActivity.TabIndex = 2;
            // 
            // tmrWaktu
            // 
            tmrWaktu.Tick += tmrWaktu_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 77);
            ClientSize = new Size(1484, 894);
            Controls.Add(pnlActivity);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel pnlActivity;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnItem;
        private Button btnDashboard;
        private Button btnService;
        private Label lblClock;
        private System.Windows.Forms.Timer tmrWaktu;
    }
}
