using DevExpress.XtraEditors;
using QLDiemSV_Winform.ApiController;
using QLDiemSV_Winform.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDiemSV_Winform.SubForm
{
    public partial class SubForm_Lay_MonHoc : DevExpress.XtraEditors.XtraForm
    {
        public int MaMonHoc { get; private set; }
        public SubForm_Lay_MonHoc(List<int> exclusionSubjectIdList)
        {
            InitializeComponent();
            form_LoadInitial(exclusionSubjectIdList);

        }

        void form_LoadInitial(List<int> exclusionSubjectIdList)
        {
            dgv_MonHoc.DataSource = dataListMonHoc_Create(exclusionSubjectIdList);
            if (dgv_MonHoc.SelectedRows.Count > 0)
            {
                btn_XacNhan.Enabled = true;
            }
        }
        private List<MonHocDTO> dataListMonHoc_Create(List<int> exclusionSubjectIdList)
        {
            List<MonHocDTO> monhocList = MonHocApiController.GetListMonHoc();
            List<MonHocDTO> currentMonHocList = new List<MonHocDTO>();
            foreach (MonHocDTO monHoc in monhocList)
            {
                bool isExclusion = false;
                foreach (int exclusionID in exclusionSubjectIdList)
                {
                    if (monHoc.MaMh == exclusionID)
                    {
                        isExclusion = true;
                        break;
                    }
                }
                if (isExclusion == false)
                {
                    currentMonHocList.Add(monHoc);
                }
            }
            return currentMonHocList;
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc chắn chọn môn học này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            MaMonHoc = Convert.ToInt32(dgv_MonHoc.SelectedRows[0].Cells["maMh"].Value);
            this.Close();
        }
    }
}