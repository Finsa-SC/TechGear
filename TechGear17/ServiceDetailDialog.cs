using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using TechGear17.Helper;

namespace TechGear17
{
    public partial class ServiceDetailDialog : Form
    {
        int serviceId;
        public ServiceDetailDialog(int serviceIds)
        {
            InitializeComponent();
            loadCategory();
            loadDataItem();
            AddButtonDGV();
            cmbSCategory.SelectedIndexChanged += loadData_byEvent;
            txtSearch.TextChanged += loadData_byEvent;
            serviceId = serviceIds;
            loadDataDetail();
            AddButtonDGV2();
        }

        private void loadCategory()
        {
            var dt = DBHelper.ExecuteQuery("select CategoryId, CategoryName from Categories");

            var dr = dt.NewRow();
            dr["CategoryId"] = 0;
            dr["CategoryName"] = "All";
            dt.Rows.InsertAt(dr, 0);

            cmbSCategory.DataSource = dt;
            cmbSCategory.DisplayMember = "CategoryName";
            cmbSCategory.ValueMember = "CategoryId";
        }
        private void loadDataItem()
        {
            string query = @"
                    select
                        i.ItemId, 
                        c.CategoryName,
                        i.ItemName as Item,
                        i.Stock,
                        i.Price
                    from Items i
                    join Categories c on c.CategoryId = i.CategoryId
                    where (@n is null or i.ItemName like @n)
                        and (@cid = 0 or i.CategoryId = @cid)";
            dgvItem.DataSource = DBHelper.ExecuteQuery(query,
                new SqlParameter("@n", "%" + txtSearch.Text + "%"),
                new SqlParameter("@cid", cmbSCategory.SelectedValue)
            );
            if (dgvItem.Columns.Contains("ItemId"))
            {
                dgvItem.Columns["ItemId"].Visible = false;
            }
        }
        private void loadDataDetail()
        {
            string query = @"
                    select 
                        i.ItemId,
                        s.ServiceId as [Servide ID],
                        i.ItemName as Item,
                        s.Qty,
                        s.Price,
                        (s.qty * s.Price) as SubTotal
                    from ServiceDetail s
                    join Items i on i.ItemId = s.ItemId
                    where s.ServiceId = @sid";
            dgvDetail.DataSource = DBHelper.ExecuteQuery(query,
                new SqlParameter("@sid", serviceId)
            );
            if (dgvDetail.Columns.Contains("ItemId")) { dgvDetail.Columns["ItemId"].Visible=false; }
        }
        private void loadData_byEvent(object sender, EventArgs e)
        {
            loadDataItem();
        }
        private void AddButtonDGV()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Add To Cart";
            btn.Name = "btnAdd";
            btn.Text = "Add";
            btn.UseColumnTextForButtonValue = true;

            dgvItem.Columns.Add(btn);
        }
        private void AddButtonDGV2()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Action";
            btn.Text = "Throw";
            btn.Name = "btnThrow";
            btn.UseColumnTextForButtonValue = true;

            dgvDetail.Columns.Add(btn);
        }

        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvItem.Columns["btnAdd"].Index)
            {
                DataGridViewRow row = dgvItem.Rows[e.RowIndex];
                int itemId = Convert.ToInt32(row.Cells["ItemId"].Value);
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                DBHelper.ExecuteNonQuery(@"
                            BEGIN TRANSACTION;
                                    update Items set Stock = Stock - 1 where ItemId = @iid and Stock > 0
                                if exists(select 1 from ServiceDetail where ServiceId = @sid and ItemId = @iid)
                                begin
                                    update ServiceDetail set Qty = Qty + 1, Subtotal = (Qty + 1) * Price where ServiceId = @sid and ItemId = @iid
                                end
                                else
                                begin
                                    insert into ServiceDetail (ServiceId, ItemId, Qty, Price, Subtotal) values (@sid, @iid, 1, @p, 1 * @p)
                                end 
                            COMMIT;",
                            new SqlParameter("@sid", serviceId),
                            new SqlParameter("@iid", itemId),
                            new SqlParameter("@p", price)
                );
                loadDataItem();
                loadDataDetail();
            }
        }

        private void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvDetail.Columns["btnThrow"].Index)
            {
                int itemId = Convert.ToInt32(dgvDetail.Rows[e.RowIndex].Cells["ItemId"].Value);
                string query = @"
                        BEGIN TRANSACTION;
                            update ServiceDetail set Qty = Qty - 1, Subtotal = (Qty - 1) * Price where ServiceId = @sid and ItemId = @iid
                            delete from ServiceDetail where ItemId = @iid and ServiceId = @sid and Qty <=0
                        commit;";
                DBHelper.ExecuteNonQuery(query,
                    new SqlParameter("@iid", itemId),
                    new SqlParameter("@sid", serviceId)
                );
            }
            loadDataDetail() ;
            loadDataItem() ;
        }
    }
}
