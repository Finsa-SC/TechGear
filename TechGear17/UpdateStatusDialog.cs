using Microsoft.Data.SqlClient;
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

namespace TechGear17
{
    public partial class UpdateStatusDialog : Form
    {
        int ServiceId;
        string status;
        public UpdateStatusDialog(int ids, string status)
        {
            InitializeComponent();
            ServiceId = ids;
            this.status = status;
            cmbStatus.SelectedItem = status;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int i = DBHelper.ExecuteNonQuery(@"
                    BEGIN TRANSACTION;
                        UPDATE Service 
                            SET ServiceStatus = @s 
                        WHERE ServiceId = @sid
                        IF @s = 'Done'
                        BEGIN
                            DECLARE @Subt DECIMAL(18,2);
                            SELECT @Subt = SUM(Subtotal) from ServiceDetail WHERE ServiceId = @sid
                            INSERT INTO TransactionService (ServiceId, SubTotal, TransactionDate)
                            VALUES (@sid, ISNULL(@Subt, 0), GETDATE())
                        END
                    COMMIT TRANSACTION;",
                new SqlParameter("@s", cmbStatus.SelectedItem),
                new SqlParameter("@sid", ServiceId)
            );

            if (i > 0) { MessageBox.Show("Success Updating Status Service!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); this.Close(); }
        }
    }
}
