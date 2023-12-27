using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDiemSV_Winform.Validation
{
    internal class KeyHandler
    {
        public KeyHandler() { }

        public static (bool handler, string errorString) TextHandler(KeyPressEventArgs e)
            => (char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar), "Chỉ nhận chữ và dấu cách");

        public static (bool handler, string errorString) DigitTextHandler(KeyPressEventArgs e)
            => (char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar), "Chỉ nhận chữ, số và dấu cách");

        public static (bool handler, string errorString) AddressHandler(KeyPressEventArgs e)
            => (char.IsSymbol(e.KeyChar) || (char.IsPunctuation(e.KeyChar) && e.KeyChar != ','), "Chỉ nhận chữ, số, dấu phẩy (,) và dấu cách");

        public static (bool handler, string errorString) NoneSpaceTeleNumberHandler(KeyPressEventArgs e)
            => (!char.IsDigit(e.KeyChar) && e.KeyChar != '+' && e.KeyChar != (char)Keys.Back, "Chỉ nhận số và dấu cộng (+)");

        public static (bool handler, string errorString) NoneSpaceDigitHandler(KeyPressEventArgs e)
            => (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back, "Chỉ nhận số");

        public static (bool handler, string errorString) CreditHandler(KeyPressEventArgs e)
        {
            return (e.KeyChar != (char)Keys.Back && (e.KeyChar < '1' || e.KeyChar > '4'), $"Chỉ nhận một trong khoảng từ 1 đến 4");
        }
        public static void CheckErrorKeyPressEvent(object sender, TextBox textBox, Label label, KeyPressEventArgs e, Func<KeyPressEventArgs, (bool handler, string errorString)> funcHandler)
        {
            label.Visible = false;
            if ((e.KeyChar != (char)Keys.Back) && (textBox.TextLength == textBox.MaxLength))
            {
                e.Handled = true;
                label.Text = $"Chỉ nhận tối đa {textBox.MaxLength} kí tự";
                label.Visible = true;
                return;
            }
            (bool handler, string stringError) = funcHandler(e);
            if (e.Handled = handler)
            {
                label.Text = stringError;
                label.Visible = true;
            }
        }
    }
}
