namespace TechGear17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnDashboard.Click += ActiveButton;
            btnItem.Click += ActiveButton;
            btnService.Click += ActiveButton;
            tmrWaktu.Start();
        }

        Color txtDefault = Color.White;
        Color bgrDefault = Color.FromArgb(33, 33, 77);
        Button currentBtn;
        private void ActiveButton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (currentBtn != null)
            {
                currentBtn.ForeColor = txtDefault;
                currentBtn.BackColor = bgrDefault;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
            btn.ForeColor = Color.MediumSlateBlue;
            btn.BackColor = Color.FromArgb(76, 76, 138);
            btn.ImageAlign = ContentAlignment.MiddleRight;
            currentBtn = btn;
        }

        private void Activity(UserControl uc)
        {
            pnlActivity.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlActivity.Controls.Add(uc);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Activity(new HistoryUC());
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            Activity(new ItemManagement());
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            Activity(new ServiceUC());
        }

        private void btnServiceD_Click(object sender, EventArgs e)
        {
        }

        private void tmrWaktu_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss");
        }
    }
}
