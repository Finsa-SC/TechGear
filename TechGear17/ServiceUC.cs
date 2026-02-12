using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechGear17.Helper;
using Microsoft.Data.SqlClient;

namespace TechGear17
{
    public partial class ServiceUC : UserControl
    {
        string status;
        public ServiceUC()
        {
            InitializeComponent();
            loadData();
            AddButtonToDGV();
        }
        int serviceId = 0;

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationHelper.OnlyNumber(e);
        }
        private void loadData()
        {
            string query = @"
                    select 
                        ServiceId as ID,
                        CustomerName as [Customer Name],
                        DamageType as [Type of Damage],
                        EntryDate as [Date Entry],
                        ServiceStatus as Status,
                        Phone
                    from Service
                    where ServiceStatus != 'Done'";
            dataGridView1.DataSource = DBHelper.ExecuteQuery(query);

        }
        private void AddButtonToDGV()
        {
            if (dataGridView1.Columns.Contains("BtnDetail")) return;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = "Detail";
            btn.Name = "btnDetail";
            btn.HeaderText = "Action";
            btn.UseColumnTextForButtonValue = true;
            btn.DefaultCellStyle.BackColor = Color.LightBlue;
            btn.DefaultCellStyle.ForeColor = Color.Black;
            btn.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            btn.DefaultCellStyle.SelectionForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;

            dataGridView1.Columns.Add(btn);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidationHelper.EmtyBox(this)) return;

            int i = DBHelper.ExecuteNonQuery("insert into Service (CustomerName, DamageType, EntryDate, ServiceStatus, Phone) values (@n, @d, GETDATE(), 'Waiting', @p)",
                new SqlParameter("@n", txtName.Text),
                new SqlParameter("@d", txtProblem.Text),
                new SqlParameter("@p", txtPhone.Text)
            );

            if (i > 0) { MessageBox.Show("Success Adding Service!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); loadData(); }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidationHelper.chekValue(serviceId)) { MessageBox.Show("Please Select One Data First!!"); return; }
            UpdateStatusDialog form = new UpdateStatusDialog(serviceId, status);
            form.ShowDialog();
            loadData();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = DBHelper.ExecuteNonQuery("delete from Service where ServiceId = @id");

            if (i > 0) { MessageBox.Show("Success Deleting Service!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); loadData(); }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            UIHelper.clearBox(this);
            serviceId = 0;
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                serviceId = Convert.ToInt32(row.Cells["ID"].Value);
                status = row.Cells["Status"].Value.ToString();
                txtName.Text = row.Cells["Customer Name"].Value.ToString();
                txtProblem.Text = row.Cells["Type of Damage"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["btnDetail"].Index)
            {
                status = dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                if (status != "In Process") return;
                int serviceIds = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

                ServiceDetailDialog form = new ServiceDetailDialog(serviceIds);
                form.ShowDialog();
                loadData();
            }
        }
    }
}
