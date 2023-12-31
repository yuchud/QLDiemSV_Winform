﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace QLDiemSV_Winform.Support
{
    internal class TabManager
    {
        public TabManager()
        {
        }

        private static (bool isExist, TabPage tabPage) CheckExists(string tabPageNameToCheck)
        {
            foreach (TabPage tabPage in Program.formChinh.GetTabControl().TabPages)
                if (tabPage.Name == tabPageNameToCheck)
                    return (true, tabPage);
            return (false, null);
        }


        public static void CloseAllForm()
        {
            foreach (TabPage tabPage in Program.formChinh.GetTabControl().TabPages)
                tabPage.Dispose();
        }

        public static void CloseForm(dynamic form)
        {
            foreach (TabPage tabPage in Program.formChinh.GetTabControl().TabPages)
                if (tabPage.Controls.Contains(form))
                {
                    Program.formChinh.GetTabControl().TabPages.Remove(tabPage);
                    tabPage.Dispose();
                    break;
                }
        }

        public static void OpenForm(dynamic form)
        {
            dynamic dynamicInstance = Activator.CreateInstance(form.GetType());
            string formName = (string)dynamicInstance.GetType().GetField("FormName").GetValue(null); 
            (bool isExist, TabPage currentTagPage) = CheckExists(formName);
            if (isExist == true)
            {
                Program.formChinh.GetTabControl().SelectedTab = currentTagPage;
                return;
            }

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            TabPage tabPage = new TabPage(formName);
            tabPage.Name = formName;
            tabPage.Controls.Add(form);

            Program.formChinh.GetTabControl().TabPages.Add(tabPage);

            form.Show();
            Program.formChinh.GetTabControl().SelectedTab = tabPage;
        }
    }
}
