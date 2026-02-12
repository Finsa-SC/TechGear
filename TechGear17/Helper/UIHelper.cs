using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechGear17.Helper
{
    internal class UIHelper
    {
        public static void clearBox(Control parent)
        {
            foreach(Control ctrl in parent.Controls)
            {
                if (ctrl.Tag != null && ctrl.Tag.ToString().ToLower().Contains("noreset")) continue;
                if(ctrl is TextBox txt)
                {
                    txt.Clear();
                }
                else if(ctrl is ComboBox cmb)
                {
                    cmb.SelectedIndex = -1;
                }
                else if(ctrl is RichTextBox rtxt)
                {
                    rtxt.Clear();
                }
                if(ctrl.HasChildren)
                {
                    clearBox(ctrl);
                }
            }
        }
    }
}
