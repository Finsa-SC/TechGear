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
    public partial class HistoryUC : UserControl
    {
        public HistoryUC()
        {
            InitializeComponent();
            loadHistory();
            txtSearch.TextChanged += loadHistory_Event;
            dteSearch.ValueChanged += loadHistory_Event;
        }

        private void loadHistory()
        {
            string query = @"
                SELECT
                    t.ServiceId,
                    t.TransactionId as ID,
                    s.CustomerName as [Customer Name],
                    s.DamageType,                    
                    s.ServiceStatus,
                    s.EntryDate,
                    FORMAT(t.TransactionDate, 'dd MMMM yyyy') as Date,
                    t.SubTotal
                FROM TransactionService t
                JOIN Service s on s.ServiceId = t.ServiceId
                WHERE (@n IS NULL OR s.CustomerName LIKE @n)
                    AND (@dte = NULL OR CAST(t.TransactionDate AS DATE) = CAST(@dte AS DATE))";
            dgvHistory.DataSource = DBHelper.ExecuteQuery(query,
                new SqlParameter("@n", "%" + txtSearch.Text + "%"),
                new SqlParameter("@dte", dteSearch.Value)
            );
            if (dgvHistory.Columns.Contains("ServiceId")) dgvHistory.Columns["ServiceId"].Visible = false; if (dgvHistory.Columns.Contains("EntryDate")) dgvHistory.Columns["EntryDate"].Visible = false; if (dgvHistory.Columns.Contains("DamageType")) dgvHistory.Columns["DamageType"].Visible = false; if (dgvHistory.Columns.Contains("ServiceStatus")) dgvHistory.Columns["ServiceStatus"].Visible = false;
        }
        private void loadHistory_Event(object sender, EventArgs e)
        {
            loadHistory();
        }
        private void loadDetail(int serviceId)
        {
            string query = @"
                    SELECT 
                        d.DetailId as ID,
                        i.ItemName as [Item],
                        d.Qty,
                        d.Price,
                        d.Subtotal
                    FROM ServiceDetail d
                    JOIN Items i on i.ItemId = d.ItemId
                    WHERE d.ServiceId = @sid";
            dgvDetail.DataSource = DBHelper.ExecuteQuery(query,
                new SqlParameter("@sid", serviceId)
            );
        }

        private void dgvHistory_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHistory.Rows[e.RowIndex];
                int serviceId = Convert.ToInt32(row.Cells["ServiceId"].Value);
                txtDamage.Text = row.Cells["DamageType"].Value.ToString();
                cmbStatus.SelectedItem = row.Cells["ServiceStatus"].Value.ToString();
                dteIn.Value = Convert.ToDateTime(row.Cells["EntryDate"].Value);
                loadDetail(serviceId);
            }
        }


    }
}
