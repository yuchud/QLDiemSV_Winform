﻿using QLDiemSV_Winform.ApiController;
using QLDiemSV_Winform.DTO;
using QLDiemSV_Winform.Secure;
using QLDiemSV_Winform.SubForm;
using QLDiemSV_Winform.Support;
using QLDiemSV_Winform.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace QLDiemSV_Winform.Form.FormQuanLy
{
    public partial class Form_Xep_LopTinChi : DevExpress.XtraEditors.XtraForm
    {
        private int maLopTinChi;

        public Form_Xep_LopTinChi()
        {
            InitializeComponent();
            form_LoadInitial();
        }

        private void btn_Chon_Click(object sender, EventArgs e)
        {
            using (SubForm_Lay_LopTinChi subForm_Lay_LopTinChi = new SubForm_Lay_LopTinChi(false))
            {
                subForm_Lay_LopTinChi.FormBorderStyle = FormBorderStyle.None;
                subForm_Lay_LopTinChi.ShowDialog();
                int current_MaLopTinChi = subForm_Lay_LopTinChi.MaLopTC;
                if (current_MaLopTinChi != 0)
                {
                    maLopTinChi = current_MaLopTinChi;
                    txt_MonHoc.ReadOnly = txt_Nam.ReadOnly = txt_Ky.ReadOnly = false;
                    txt_Nam.Text = subForm_Lay_LopTinChi.Nam.ToString();
                    txt_MonHoc.Text = SubjectPairGenerator.GetTenMonHoc(subForm_Lay_LopTinChi.MaMH);
                    txt_Ky.Text = subForm_Lay_LopTinChi.Ky.ToString();
                    txt_MonHoc.ReadOnly = txt_Nam.ReadOnly = txt_Ky.ReadOnly = true;
                    form_LoadInitial();
                }
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            using (SubForm_Lay_SinhVien subForm_Lay_SinhVien = new SubForm_Lay_SinhVien(
                exclusionStudentsIdList_Create()))
            {
                subForm_Lay_SinhVien.FormBorderStyle = FormBorderStyle.None;
                subForm_Lay_SinhVien.ShowDialog();
                int maSinhVien = subForm_Lay_SinhVien.MaSinhVien;
                if (maSinhVien != 0)
                {
                    HttpStatusCode httpStatusCode = BangDiemApiController.PostBangDiem(dataBangDiem_Create(maSinhVien));

                    if (StatusCodeChecker.GetResponseClass(httpStatusCode) ==
                        EnumCode.HTTPResponseStatusClass.SuccessfulResponses)
                    {
                        MessageBox.Show(
                            $"Thêm sinh viên vào lớp tín chỉ thành công!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        form_LoadInitial();
                    }
                    else
                        MessageBox.Show(
                            $"Thêm sinh viên vào lớp tín chỉ thất bại!. Status code: {httpStatusCode}",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e) { TabManager.CloseForm(this); }

        private (bool canDelete, string error) btn_Xoa_CheckBeforeDelete()
        {
            int maBangDiem = Convert.ToInt32(dgv_SinhVien.SelectedRows[0].Cells["maBangDiem"].Value);
            if (BangDiemApiController.GetBangDiem(maBangDiem).TongKet > 0.0)
                return (false, "Không thể xóa vì ở lớp tín chỉ này sinh viên đã có điểm");
            return (true, string.Empty);
        }


        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            (bool canDelete, string error) = btn_Xoa_CheckBeforeDelete();

            if (canDelete == false)
            {
                MessageBox.Show(error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc chắn xóa sinh viên này khỏi lớp tín chỉ?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
                return;
            int maSinhVien = Convert.ToInt32(dgv_SinhVien.SelectedRows[0].Cells["maSv"].Value);
            bool isDeletionSuccessful = BangDiemApiController.DeleteBangDiem(maLopTinChi, maSinhVien) ==
                EnumCode.ApiDeleteResult.Success;

            if (isDeletionSuccessful)
            {
                MessageBox.Show("Xóa sinh viên thành công!");
                form_LoadInitial();
                // Perform additional actions after a successful deletion if needed
            }
            else
                MessageBox.Show("Xóa sinh viên thất bại.");
        }

        private List<BangDiemInfoDTO> dataBangDiem_Create()
        { return BangDiemApiController.GetListBangDiemByMaLopTinChi(maLopTinChi); }

        private BangDiemDTO dataBangDiem_Create(int maSinhVien)
        { return new BangDiemDTO(0, maLopTinChi, maSinhVien, 0, 0, 0, 0, 0, 0); }

        private void dgv_SinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_SinhVien.SelectedRows.Count > 0)
                btn_Xoa.Enabled = true;
        }

        private void dgv_SinhVienLopTinChi_LoadData()
        {
            dgv_SinhVien.DataSource = dataBangDiem_Create();
            DataGridViewManager.HideColumn(dgv_SinhVien, "maLopTc");
            DataGridViewManager.HideColumn(dgv_SinhVien, "chuyenCan");
            DataGridViewManager.HideColumn(dgv_SinhVien, "baiTap");
            DataGridViewManager.HideColumn(dgv_SinhVien, "kiemTra");
            DataGridViewManager.HideColumn(dgv_SinhVien, "thucHanh");
            DataGridViewManager.HideColumn(dgv_SinhVien, "thi");
            DataGridViewManager.HideColumn(dgv_SinhVien, "tongKet");
        }

        private List<int> exclusionStudentsIdList_Create()
        {
            List<BangDiemInfoDTO> sinhVienList = dataBangDiem_Create();
            List<int> exclusionStudentsIdList = new List<int>();
            exclusionStudentsIdList.AddRange(sinhVienList.Select(sinhVien => sinhVien.MaSv));
            return exclusionStudentsIdList;
        }

        private void form_LoadInitial()
        {
            dgv_SinhVienLopTinChi_LoadData();
            if (maLopTinChi != 0)
                btn_Them.Enabled = true;
            else
                btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;
        }
    }
}