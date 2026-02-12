using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechGear17.Helper
{
    internal class ValidationHelper
    {
        public static void OnlyNumber(KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        public static bool chekValue(object obj)
        {
            if(obj == null || obj == DBNull.Value)
            {
                return true;
            }
            if((int)obj < 1)
            {
                return true;
            }
            return false;
        }

        public static bool EmtyBox(Control parent)
        {
            foreach(Control ctrl in parent.Controls)
            {
                if (ctrl.Tag != null && ctrl.Tag.ToString().Contains("optional")) continue;
                if(ctrl is TextBox txt)
                {
                    if(string.IsNullOrWhiteSpace(txt.Text)) { MessageBox.Show("Please Fill All of Block!!", "Emty Text", MessageBoxButtons.OK, MessageBoxIcon.Information); txt.Focus(); return true; }
                }
                else if (ctrl is RichTextBox rtxt)
                {
                    if (string.IsNullOrWhiteSpace(rtxt.Text)) { MessageBox.Show("Please Fill All of Block!!", "Emty Text", MessageBoxButtons.OK, MessageBoxIcon.Information); rtxt.Focus(); return true; }
                }
                else if (ctrl is ComboBox cmb)
                {
                    if (cmb.SelectedIndex < 0) { MessageBox.Show("Please One of Decision!!", "Emty Text", MessageBoxButtons.OK, MessageBoxIcon.Information); cmb.Focus(); return true; }
                }
                if (ctrl.HasChildren)
                {
                    if(EmtyBox(ctrl)) return true;
                }
            }
            return false;
        }

    }
}
