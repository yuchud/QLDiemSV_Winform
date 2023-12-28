using System;
using System.Linq;
using System.Windows.Forms;

namespace QLDiemSV_Winform.Support
{
    internal class DataGridViewManager
    {
        public DataGridViewManager()
        {
        }

        public static void HideColumn(DataGridView dataGridView, string columnName)
        {
            if (dataGridView.Columns.Contains(columnName))
                dataGridView.Columns[columnName].Visible = false;
        }

        public static void ChangeHeaderText(DataGridView dataGridView, string columnName, string headerTexxt)
        {
            int currentDisplayIndex = dataGridView.Columns[columnName].DisplayIndex;

            dataGridView.Columns[columnName].HeaderText = headerTexxt;

            dataGridView.Columns[columnName].DisplayIndex = currentDisplayIndex;

        }


    }
}
