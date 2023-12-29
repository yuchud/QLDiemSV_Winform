using DevExpress.Utils.Drawing;
using QLDiemSV_Winform.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDiemSV_Winform.Support
{
    internal class MessageBoxManager
    {
        public MessageBoxManager()
        {
        }


        public static bool OpenMessageBox(string action, string target, string from = "")
        {
            string message = $"Bạn có chắc {action} {target}";
            if (from.Length > 0)
            {
                if (action == ConstantValues.ActionCreate) message += " vào ";
                else if (action == ConstantValues.ActionDelete) message += " khỏi ";
                message += from;
            }
            message += "?";


            DialogResult dialogResult = MessageBox.Show(
                message,
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            return (dialogResult == DialogResult.Yes);
        }

        public static bool ShowResult(HttpStatusCode httpStatusCode, string action, string target, string from = "")
        {
            MessageBoxIcon messageBoxIcon = MessageBoxIcon.None;
            string message = $"{action} {target}";

            if (from.Length > 0)
            {
                if (action == ConstantValues.ActionCreate) message += " vào ";
                else if (action == ConstantValues.ActionDelete) message += " khỏi ";
                message += from;
            }

            bool isSuccesseful;
            if(StatusCodeChecker.GetResponseClass(httpStatusCode) ==
                EnumCode.HTTPResponseStatusClass.SuccessfulResponses)
            {
                message += " thành công!";
                messageBoxIcon = MessageBoxIcon.Information;
                isSuccesseful = true;
            } else
            {
                message += $" thất bại!, StatusCode = {httpStatusCode}";
                messageBoxIcon = MessageBoxIcon.Error;
                isSuccesseful = false;
            }
            DialogResult dialogResult = MessageBox.Show(message, "Xác nhận", MessageBoxButtons.OK, messageBoxIcon);
            return isSuccesseful;
        }
    }
}
