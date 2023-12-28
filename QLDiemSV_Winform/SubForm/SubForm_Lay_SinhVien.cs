using QLDiemSV_Winform.ApiController;
using QLDiemSV_Winform.DTO;
using QLDiemSV_Winform.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QLDiemSV_Winform.SubForm
{
    public partial class SubForm_Lay_SinhVien : DevExpress.XtraEditors.XtraForm
    {
        private List<int> exclusionStudentsIdList;
        private int maLopSinhVien;

        public SubForm_Lay_SinhVien(List<int> exclusionStudentsIdList)
        {
            InitializeComponent();
            this.exclusionStudentsIdList = exclusionStudentsIdList;
            form_LoadInitial();
        }

        private void btn_Chon_Click(object sender, EventArgs e)
        {
            using (SubForm_Lay_LopSinhVien subForm_Lay_LopSinhVien = new SubForm_Lay_LopSinhVien())
            {
                subForm_Lay_LopSinhVien.FormBorderStyle = FormBorderStyle.None;
                subForm_Lay_LopSinhVien.ShowDialog();
                int currentMaLopSinhVien = subForm_Lay_LopSinhVien.MaLopSinhVien;
                if (currentMaLopSinhVien != 0)
                {
                    maLopSinhVien = currentMaLopSinhVien;
                    txt_Khoa.ReadOnly = txt_Lop.ReadOnly = false;
                    txt_Lop.Text = subForm_Lay_LopSinhVien.TenLopSinhVien;
                    txt_Khoa.Text = subForm_Lay_LopSinhVien.TenKhoa;
                    txt_Khoa.ReadOnly = txt_Lop.ReadOnly = true;
                    form_LoadInitial();
                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e) { this.Close(); }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc chắn thêm sinh viên này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
                return;
            MaSinhVien = Convert.ToInt32(dgv_SinhVien.SelectedRows[0].Cells["maSv"].Value);
            this.Close();
        }

        private List<SinhVienDTO> dataSinhVienList_Create()
        {
            List<SinhVienDTO> sinhVienList = SinhVienApiController.GetListSinhVienByMaLopSinhVien(maLopSinhVien);
            List<SinhVienDTO> currentSinhVienList = new List<SinhVienDTO>();
            foreach (SinhVienDTO SinhVien in sinhVienList)
            {
                bool isExclusion = false;
                foreach (int exclusionID in exclusionStudentsIdList)
                    if (SinhVien.MaSv == exclusionID)
                    {
                        isExclusion = true;
                        break;
                    }
                if (isExclusion == false)
                    currentSinhVienList.Add(SinhVien);
            }
            return currentSinhVienList;
        }

        private void dgv_SinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_SinhVien.SelectedRows.Count > 0)
                btn_XacNhan.Enabled = true;
        }

        private void dgv_SinhVien_FillData()
        {
            dgv_SinhVien.DataSource = dataSinhVienList_Create();
            DataGridViewManager.HideColumn(dgv_SinhVien, "maLopSv");
            lbl_SoLuong.Text = dgv_SinhVien.RowCount.ToString();
            dgv_SinhVien.ClearSelection();
        }

        public void form_LoadInitial()
        {
            dgv_SinhVien_FillData();
            btn_XacNhan.Enabled = false;
        }

        public int MaSinhVien { get; private set; }
    }
}