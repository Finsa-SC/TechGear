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
    public partial class ItemManagement : UserControl
    {
        public ItemManagement()
        {
            InitializeComponent();
            loadCategory();
            loadCategorySearch();
            loadData();
        }
        int Itemids = 0;

        private void loadCategorySearch()
        {
            string query = "select CategoryId, CategoryName from Categories";

            var dt = DBHelper.ExecuteQuery(query);
            var dr = dt.NewRow();
            dr["CategoryId"] = 0;
            dr["CategoryName"] = "All";
            dt.Rows.InsertAt(dr, 0);

            cmbSCategory.DataSource = dt;
            cmbSCategory.DisplayMember = "CategoryName";
            cmbSCategory.ValueMember = "CategoryId";
        }
        private void loadCategory()
        {
            string query = "select CategoryId, CategoryName from Categories";

            cmbCategory.DataSource = DBHelper.ExecuteQuery(query);
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.SelectedIndex = -1;
        }

        private void loadData()
        {
            string query = @"
                        select 
                            i.ItemId as ID,
                            c.CategoryName as Category,
                            i.ItemName as [Item Name],
                            i.Stock,
                            i.Price
                        from Items i
                        join Categories c on c.CategoryId = i.CategoryId
                        where (@n is null or i.ItemName like @n)
                            and (@cid = 0 or c.CategoryId = @cid)";

            dataGridView1.DataSource = DBHelper.ExecuteQuery(query,
                new SqlParameter("@cid", cmbSCategory.SelectedValue),
                new SqlParameter("@n", "%" + txtSearch.Text + "%")
            );
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationHelper.OnlyNumber(e);
        }
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationHelper.OnlyNumber(e);
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Itemids = Convert.ToInt32(row.Cells["ID"].Value);
                txtName.Text = row.Cells["Item Name"].Value.ToString();
                cmbCategory.SelectedIndex = cmbCategory.FindStringExact(row.Cells["Category"].Value.ToString());
                txtStock.Text = Convert.ToInt32(row.Cells["Stock"].Value).ToString();
                txtPrice.Text = Convert.ToInt32(row.Cells["Price"].Value).ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidationHelper.EmtyBox(this)) return;
            string query = "insert into Items (CategoryId, ItemName, Stock, Price) values (@cid, @n, @s, @p)";

            int i = DBHelper.ExecuteNonQuery(query,
                new SqlParameter("@cid", cmbCategory.SelectedValue),
                new SqlParameter("@n", txtName.Text),
                new SqlParameter("@s", Convert.ToInt32(txtStock.Text)),
                new SqlParameter("@p", Convert.ToDecimal(txtPrice.Text))
            );
            if (i > 0) { MessageBox.Show("Success Adding Items!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); loadData(); }
            UIHelper.clearBox(this);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidationHelper.EmtyBox(this)) return;
            if (ValidationHelper.chekValue(Itemids)) { MessageBox.Show("Select Data First!!", "No Data Select", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string query = "update Items set CategoryId = @cid, ItemName = @n, Stock = @s, Price = @p where ItemId = @id";

            int i = DBHelper.ExecuteNonQuery(query,
                new SqlParameter("@cid", cmbCategory.SelectedValue),
                new SqlParameter("@n", txtName.Text),
                new SqlParameter("@s", Convert.ToInt32(txtStock.Text)),
                new SqlParameter("@p", Convert.ToDecimal(txtPrice.Text)),
                new SqlParameter("@id", Itemids)
            );
            if (i > 0) { MessageBox.Show("Success Updating Items!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); loadData(); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ValidationHelper.chekValue(Itemids)) { MessageBox.Show("Select Data First!!", "No Data Select", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string query = "delete from Items where ItemId = @id";

            int i = DBHelper.ExecuteNonQuery(query,
                new SqlParameter("@id", Itemids)
            );
            if (i > 0) { MessageBox.Show("Success Deleting Items!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); loadData(); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            UIHelper.clearBox(this);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void cmbSCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int stock = Convert.ToInt32(row.Cells["Stock"].Value);
                if (stock < 1)
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (stock <= 10)
                {
                    row.DefaultCellStyle.BackColor = Color.Khaki;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            toolTip1.SetToolTip(btn, "Tambah user");

        }
    }
}
