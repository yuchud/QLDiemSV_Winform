using System;
using System.Linq;
using System.Windows.Forms;

namespace QLDiemSV_Winform.Validation
{
    internal class FieldValidation
    {
        public FieldValidation()
        {
        }

        public static void PercentIntValidation(TextBox textBox, KeyPressEventArgs e)
        {
            if (textBox.Text.Length == 0)
                return;
            if (textBox.Text == "0")
                textBox.Text = e.KeyChar.ToString();
        }
    }
}
