using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDiemSV_Winform.Support
{
    internal class DataGridViewManager
    {
        public DataGridViewManager() { }

        public static void HideColumn(DataGridView dataGridView, string columnName)
        {
            if (dataGridView.Columns.Contains(columnName))
            {
                dataGridView.Columns[columnName].Visible = false;
            }
        }
    }
}
