﻿using QLDiemSV_Winform.ApiController;
using QLDiemSV_Winform.Controller;
using QLDiemSV_Winform.DTO;
using QLDiemSV_Winform.Secure;
using QLDiemSV_Winform.Support;
using QLDiemSV_Winform.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace QLDiemSV_Winform.Form
{
    public partial class Form_QL_GiangVien : DevExpress.XtraEditors.XtraForm
    {
        private static readonly string Action = ConstantValues.ActionManage;
        private static readonly string Target = ConstantValues.TargetTeacher;
        public static readonly string FormName = Action + (Action.Length > 0 && Target.Length > 0 ? " " : "") + Target;
        public Form_QL_GiangVien()
        {
            InitializeComponent();
            cmb_Khoa_FillData();
            form_LoadInitial();
            dgv_GiangVien.ClearSelection();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            inputField_FillData(Convert.ToInt32(txt_Ma.Text));
            inputField_Close();
        }

        private void btn_Sua_Click(object sender, EventArgs e) => inputField_Open();

        private void btn_Them_Click(object sender, EventArgs e)
        {
            inputField_Open();
            inputField_PrepareForAdd();
        }

        private void btn_Thoat_Click(object sender, EventArgs e) => TabManager.CloseForm(this);

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (inputField_CheckNoneEmpty() == false) return;
            bool isAdding = txt_Ma.Text == "0";
            string editAction = (isAdding) ? ConstantValues.ActionCreate : ConstantValues.ActionUpdate;

            if (MessageBoxManager.OpenMessageBox(editAction, Target) == false)
                return;

            HttpStatusCode httpStatusCode;
            if (isAdding)
                httpStatusCode = GiangVienController.PostGiangVien(dataGiangVien_Create(0));
            else
                httpStatusCode = GiangVienController.PutGiangVien(
                    dataGiangVien_Create(Convert.ToInt32(txt_Ma.Text)));

            bool isSuccessful = MessageBoxManager.ShowResult(httpStatusCode, editAction, Target);
            if(isSuccessful)
            {
                if (isAdding)
                    form_LoadInitial();
                else
                {
                    int currentSelectedRow = dgv_GiangVien.SelectedRows[0].Index;
                    dgv_GiangVien_FillData(dataMaKhoa_Get());
                    dgv_GiangVien.Rows[currentSelectedRow].Selected = true;
                }
            }
            inputField_Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int maGiangVien = Convert.ToInt32(txt_Ma.Text);
            if (MessageBoxManager.OpenMessageBox(ConstantValues.ActionDelete, Target) == false) return;

            if (MessageBoxManager.ShowResult(GiangVienController.DeleteGiangVien(maGiangVien), ConstantValues.ActionDelete, Target)) form_LoadInitial();
        }

        private void cmb_Khoa_FillData()
        {
            cmb_Khoa.DataSource = KhoaController.GetAllKhoa();
            cmb_Khoa.DisplayMember = "tenKhoa";
            cmb_Khoa.ValueMember = "maKhoa";
        }

        private void cmb_Khoa_SelectedIndexChanged(object sender, EventArgs e) => form_LoadInitial();

        private GiangVienDTO dataGiangVien_Create(int MaGiangVien)
        {
            string ho = txt_Ho.Text;
            string ten = txt_Ten.Text;
            string diaChi = txt_DiaChi.Text;
            string sdt = txt_SDT.Text;
            int maKhoa = dataMaKhoa_Get();
            int maQuyen;
            if (cb_ChucVu.Checked == true)
                maQuyen = TeacherDecentralization.GetMaQuyenGiangVien(EnumCode.Decentralization.NhanVien);
            else
                maQuyen = TeacherDecentralization.GetMaQuyenGiangVien(EnumCode.Decentralization.GiangVien);
            return new GiangVienDTO(MaGiangVien, ho, ten, diaChi, sdt, maKhoa, maQuyen);
        }

        private int dataMaKhoa_Get()
        {
            dynamic khoa = cmb_Khoa.SelectedItem;
            return khoa.MaKhoa;
        }

        private void dgv_GiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_GiangVien.SelectedRows.Count > 0)
            {
                btn_Xoa.Enabled = btn_Sua.Enabled = true;
                int maGiangVien = Convert.ToInt32(dgv_GiangVien.SelectedRows[0].Cells["MaGV"].Value);
                inputField_FillData(maGiangVien);
            }
        }

        private void dgv_GiangVien_FillData(int MaKhoa)
        {
            dgv_GiangVien.DataSource = GiangVienController.GetListGiangVienByMaKhoa(MaKhoa);
            DataGridViewManager.HideColumn(dgv_GiangVien, "maKhoa");
            DataGridViewManager.HideColumn(dgv_GiangVien, "maQuyen");
            lbl_SoLuong.Text = dgv_GiangVien.RowCount.ToString();
            dgv_GiangVien.ClearSelection();
        }

        private bool inputField_CheckNoneEmpty()
        {
            lbl_error_Ho.Visible = lbl_error_Ten.Visible = lbl_error_DiaChi.Visible = lbl_error_SDT.Visible = false;
            if (txt_Ho.Text == string.Empty)
            {
                lbl_error_Ho.Text = "Vui lòng nhập Họ";
                lbl_error_Ho.Visible = true;
                return false;
            } else if (txt_Ten.Text == string.Empty)
            {
                lbl_error_Ten.Text = "Vui lòng nhập Tên";
                lbl_error_Ten.Visible = true;
                return false;
            } else if (txt_DiaChi.Text == string.Empty)
            {
                lbl_error_DiaChi.Text = "Vui lòng nhập Địa chỉ";
                lbl_error_DiaChi.Visible = true;
                return false;
            } else if (txt_SDT.Text.Length < 6)
            {
                lbl_error_SDT.Text = "Số điện thoại cần ít nhất 6 kí tự";
                lbl_error_SDT.Visible = true;
                return false;
            }
            return true;
        }

        private void inputField_ClearAllData()
        {
            txt_Ma.Enabled = true;
            txt_Ma.Text = txt_Ho.Text = txt_Ten.Text = txt_DiaChi.Text = txt_SDT.Text = string.Empty;
            cb_ChucVu.Checked = false;
            txt_Ma.Enabled = false;
        }


        private void inputField_Close()
        {
            if (dgv_GiangVien.SelectedRows.Count > 0)
                btn_Sua.Enabled = btn_Xoa.Enabled = true;
            dgv_GiangVien.Enabled = true;
            cmb_Khoa.Enabled = true;

            btn_Them.Enabled = btn_Xoa.Enabled = btn_Sua.Enabled = btn_Thoat.Enabled = true;
            btn_XacNhan.Enabled = btn_Huy.Enabled = false;

            lbl_error_Ho.Visible = lbl_error_Ten.Visible = lbl_error_DiaChi.Visible = lbl_error_SDT.Visible = false;
            txt_Ho.ReadOnly = txt_Ten.ReadOnly = txt_SDT.ReadOnly = txt_DiaChi.ReadOnly = true;
            cb_ChucVu.Enabled = false;
        }

        private void inputField_FillData(int maGiangVien)
        {
            if (maGiangVien == 0)
            {
                inputField_ClearAllData();
                return;
            }
            GiangVienDTO GiangVien = GiangVienController.GetGiangVien(maGiangVien);
            txt_Ma.Enabled = true;
            txt_Ma.Text = GiangVien.MaGv.ToString();
            txt_Ma.Enabled = false;
            txt_Ho.Text = GiangVien.Ho;
            txt_Ten.Text = GiangVien.Ten;
            txt_DiaChi.Text = GiangVien.DiaChi;
            txt_SDT.Text = GiangVien.Sdt;
            int maQuyen = GiangVien.MaQuyen;
            cb_ChucVu.Checked = (TeacherDecentralization.GetQuyenGiangVien(maQuyen) ==
                EnumCode.Decentralization.NhanVien);
        }


        private void inputField_Open()
        {
            dgv_GiangVien.Enabled = false;
            cmb_Khoa.Enabled = false;

            btn_Them.Enabled = btn_Xoa.Enabled = btn_Sua.Enabled = btn_Thoat.Enabled = false;
            btn_XacNhan.Enabled = btn_Huy.Enabled = true;

            txt_Ho.ReadOnly = txt_Ten.ReadOnly = txt_SDT.ReadOnly = txt_DiaChi.ReadOnly = false;
            if (txt_Ma.Text != SecureStorage.GetTenDangNhap())
                cb_ChucVu.Enabled = true;
        }

        private void inputField_PrepareForAdd()
        {
            inputField_ClearAllData();
            txt_Ma.Enabled = true;
            txt_Ma.Text = "0";
            txt_Ma.Enabled = false;
        }


        private void listGiangVien_GenerateChucVu(List<GiangVienDTO> listGiangVien)
        {
            foreach (GiangVienDTO giangVien in listGiangVien)
                giangVien.GenerateChucVu();
        }

        private void txt_DiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyHandler.CheckErrorKeyPressEvent(sender, lbl_error_DiaChi, e, KeyHandler.AddressHandler);
        }

        private void txt_DiaChi_Leave(object sender, EventArgs e)
        {
            lbl_error_DiaChi.Visible = false;
            txt_DiaChi.Text = Standardize.StandardizeText(txt_DiaChi.Text);
        }

        private void txt_Ho_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyHandler.CheckErrorKeyPressEvent(sender, lbl_error_Ho, e, KeyHandler.TextHandler);
        }

        private void txt_Ho_Leave(object sender, EventArgs e)
        {
            lbl_error_Ho.Visible = false;
            txt_Ho.Text = Standardize.StandardizeText(txt_Ho.Text);
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyHandler.CheckErrorKeyPressEvent(sender, lbl_error_SDT, e, KeyHandler.NoneSpaceTeleNumberHandler);
        }

        private void txt_Ten_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyHandler.CheckErrorKeyPressEvent(sender, lbl_error_Ten, e, KeyHandler.TextHandler);
        }

        private void txt_Ten_Leave(object sender, EventArgs e)
        {
            lbl_error_Ten.Visible = false;
            txt_Ten.Text = Standardize.StandardizeText(txt_Ten.Text);
        }


        public void form_LoadInitial()
        {
            dgv_GiangVien_FillData(dataMaKhoa_Get());
            inputField_ClearAllData();
            inputField_Close();
            btn_Xoa.Enabled = btn_Sua.Enabled = false;
        }

        public void form_LoadInitial(int maKhoa)
        {
            dgv_GiangVien_FillData(maKhoa);
            inputField_ClearAllData();
            inputField_Close();
            btn_Xoa.Enabled = btn_Sua.Enabled = false;
        }
    }
}