using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Proj_Presentation
{
    public static class FormHelper
    {
        public static void ClearTextBoxes(Control parentControl)
        {
            foreach (Control ctrl in parentControl.Controls)
            {
                if (ctrl is TextBox txtBox)
                {
                    txtBox.Text = string.Empty;
                }
                else if (ctrl.HasChildren)
                {
                    ClearTextBoxes(ctrl);
                }
            }
        }
    }
}
