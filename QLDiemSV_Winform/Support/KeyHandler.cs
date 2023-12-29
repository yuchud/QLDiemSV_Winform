using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLDiemSV_Winform.Validation
{
    internal class KeyHandler
    {
        public KeyHandler()
        {
        }

        public static (bool handler, string errorString) AddressHandler(KeyPressEventArgs e) => (char.IsSymbol(
                e.KeyChar) ||
            (char.IsPunctuation(e.KeyChar) && e.KeyChar != ','), "Chỉ nhận chữ, số, dấu phẩy (,) và dấu cách");

        public static void CheckErrorKeyPressEvent(
            object sender,
            Label label,
            KeyPressEventArgs e,
            Func<KeyPressEventArgs, (bool handler, string errorString)> funcHandler)
        {
            TextBox currentTextBox = (TextBox) sender;
            label.Visible = false;
            if ((e.KeyChar != (char)Keys.Back) && (currentTextBox.TextLength == currentTextBox.MaxLength))
            {
                e.Handled = true;
                label.Text = $"Chỉ nhận tối đa {currentTextBox.MaxLength} kí tự";
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

        private static void setErrorLabel(object sender, Label label, KeyPressEventArgs e)
        {

            label.Text = "Chỉ nhận điểm theo dạng:\n x(với 0 <= x <= 9) \n x, hoặc x. \n x, x hoặc x.x \n 10";
            label.Visible = true;
            e.Handled = true;
        }

        public static void CheckErrorMarkKeyPressEvent(
            object sender,
            Label label,
            KeyPressEventArgs e,
            Func<KeyPressEventArgs, (bool handler, string errorString)> funcHandler)
        {
            label.Visible = false;
            (bool handler, string stringError) = funcHandler(e);
            if (e.Handled = handler)
            {
                label.Text = stringError;
                label.Visible = true;
            }
        }


        public static (bool handler, string errorString) CreditHandler(KeyPressEventArgs e)
        {
            return (e.KeyChar != (char)Keys.Back && (e.KeyChar < '1' || e.KeyChar > '4'), $"Chỉ nhận một trong khoảng từ 1 đến 4");
        }

        public static (bool handler, string errorString) DigitTextHandler(KeyPressEventArgs e)
        { return (char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar), "Chỉ nhận chữ, số và dấu cách"); }

        public static (bool handler, string errorString) NoneSpaceDigitHandler(KeyPressEventArgs e)
        { return (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back, "Chỉ nhận số"); }

        public static (bool handler, string errorString) NoneSpaceTeleNumberHandler(KeyPressEventArgs e)
        {
            return (!char.IsDigit(e.KeyChar) && e.KeyChar != '+' && e.KeyChar != (char)Keys.Back, "Chỉ nhận số và dấu cộng (+)");
        }

        public static (bool handler, string errorString) TextHandler(KeyPressEventArgs e) => (char.IsDigit(e.KeyChar) ||
            char.IsSymbol(e.KeyChar) ||
            char.IsPunctuation(e.KeyChar), "Chỉ nhận chữ và dấu cách");

        public static (bool handler, string errorString) NoneSpaceDoubleHandler(KeyPressEventArgs e)
        { return (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',' && e.KeyChar != '.', "Chỉ nhận số và dấu chấm (.) hoặc phẩy (,)"); }
    }
}
