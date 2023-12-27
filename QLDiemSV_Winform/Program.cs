using QLDiemSV_Winform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDiemSV_Winform
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static FormChinh formChinh;
        public static string ApiBaseUrl = "https://localhost:44343/api";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formChinh = new FormChinh();
            Application.Run(formChinh);
        }
    }
}
