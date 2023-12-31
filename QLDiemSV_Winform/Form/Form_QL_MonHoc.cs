﻿using QLDiemSV_Winform.ApiController;
using QLDiemSV_Winform.DTO;
using QLDiemSV_Winform.Secure;
using QLDiemSV_Winform.Support;
using QLDiemSV_Winform.Validation;
using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace QLDiemSV_Winform.Form
{
    public partial class Form_QL_MonHoc : DevExpress.XtraEditors.XtraForm
    {
        private static readonly string Action = ConstantValues.ActionManage;
        private static readonly string Target = ConstantValues.TargetSubject;
        public static readonly string FormName = Action + (Action.Length > 0 && Target.Length > 0 ? " " : "") + Target;
        public Form_QL_MonHoc()
        {
            InitializeComponent();
            form_LoadInitial();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            inputField_FillData(Convert.ToInt32(txt_Ma.Text));
            inputField_Close();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            inputField_Open();
            int maMonHoc = Convert.ToInt32(txt_Ma.Text);
            if (LopTinChiController.GetListLopTinChiByMaMonHoc(maMonHoc).Count > 0)
                txt_CC.ReadOnly = txt_BT.ReadOnly =
                    txt_KT.ReadOnly =
                    txt_TH.ReadOnly =
                    txt_Thi.ReadOnly =
                    txt_SoTinChi.ReadOnly =
                    true;
        }

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
                httpStatusCode = MonHocController.PostMonHoc(dataMonHoc_Create(0));
            else
                httpStatusCode = MonHocController.PutMonHoc(
                    dataMonHoc_Create(Convert.ToInt32(txt_Ma.Text)));

            bool isSuccessful = MessageBoxManager.ShowResult(httpStatusCode, editAction, Target);
            if (isSuccessful)
            {
                if (isAdding)
                    form_LoadInitial();
                else
                {
                    int currentSelectedRow = dgv_MonHoc.SelectedRows[0].Index;
                    dgv_MonHoc_FillData();
                    dgv_MonHoc.Rows[currentSelectedRow].Selected = true;
                }
            }
            inputField_Close();
        }

        private (bool canDelete, string error) btn_Xoa_CheckBeforeDelete(int maMonHoc)
        {
            if (LopTinChiController.GetListLopTinChiByMaMonHoc(maMonHoc).Count > 0)
                return (false, "Môn học đã được đăng ký lớp tín chỉ, không thể xóa");
            return (true, string.Empty);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int maMonHoc = Convert.ToInt32(txt_Ma.Text);

            (bool canDelete, string error) = btn_Xoa_CheckBeforeDelete(maMonHoc);

            if (canDelete == false)
            {
                MessageBox.Show(error);
                return;
            }

            if (MessageBoxManager.OpenMessageBox(ConstantValues.ActionDelete, Target) == false) return;

            if (MessageBoxManager.ShowResult(MonHocController.DeleteMonHoc(maMonHoc), ConstantValues.ActionDelete, Target)) form_LoadInitial();
        }


        private MonHocDTO dataMonHoc_Create(int MaMonHoc)
        {
            string ten = txt_Ten.Text;
            int cc = Convert.ToInt32(txt_CC.Text);
            int bt = Convert.ToInt32(txt_BT.Text);
            int kt = Convert.ToInt32(txt_KT.Text);
            int th = Convert.ToInt32(txt_TH.Text);
            int thi = Convert.ToInt32(txt_Thi.Text);
            int soTinChi = Convert.ToInt32(txt_SoTinChi.Text);
            return new MonHocDTO(MaMonHoc, ten, cc, bt, kt, th, thi, soTinChi);
        }

        private void dgv_MonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_MonHoc.SelectedRows.Count > 0)
            {
                btn_Xoa.Enabled = btn_Sua.Enabled = true;
                int maMonHoc = Convert.ToInt32(dgv_MonHoc.SelectedRows[0].Cells["maMh"].Value);
                inputField_FillData(maMonHoc);
            }
        }

        private void dgv_MonHoc_FillData()
        {
            dgv_MonHoc.DataSource = MonHocController.GetListMonHoc();
            DataGridViewManager.HideColumn(dgv_MonHoc, "maKhoa");
            lbl_SoLuong.Text = dgv_MonHoc.RowCount.ToString();
            dgv_MonHoc.ClearSelection();
        }

        private bool inputField_CheckNoneEmpty()
        {
            lbl_error_Ten.Visible = false;
            if (txt_Ten.Text == string.Empty)
            {
                lbl_error_Ten.Text = "Vui lòng nhập Tên";
                lbl_error_Ten.Visible = true;
                return false;
            }
            if (txt_SoTinChi.Text == string.Empty)
            {
                lbl_error_SoTinChi.Text = "Vui lòng nhập số tín chỉ";
                lbl_error_SoTinChi.Visible = true;
                return false;
            }
            return true;
        }

        private void inputField_ClearAllData()
        {
            txt_Ma.Enabled = true;
            txt_Ten.Text = string.Empty;
            txt_CC.Text = txt_BT.Text = txt_KT.Text = txt_TH.Text = txt_Thi.Text = lbl_TongTrongSo.Text = "0";
            txt_SoTinChi.Text = string.Empty;
            txt_Ma.Enabled = false;
        }

        private void inputField_Close()
        {
            if (dgv_MonHoc.SelectedRows.Count > 0)
                btn_Sua.Enabled = btn_Xoa.Enabled = true;
            dgv_MonHoc.Enabled = true;

            btn_Them.Enabled = btn_Xoa.Enabled = btn_Sua.Enabled = btn_Thoat.Enabled = true;
            btn_XacNhan.Enabled = btn_Huy.Enabled = false;

            lbl_error_Ten.Visible = lbl_error_TS.Visible = lbl_error_SoTinChi.Visible = false;
            txt_Ten.ReadOnly = txt_CC.ReadOnly =
                txt_BT.ReadOnly =
                txt_KT.ReadOnly =
                txt_TH.ReadOnly =
                txt_Thi.ReadOnly =
                txt_SoTinChi.ReadOnly =
                true;
        }

        private void inputField_FillData(int maMonHoc)
        {
            if (maMonHoc == 0)
            {
                inputField_ClearAllData();
                return;
            }
            MonHocDTO monHoc = MonHocController.GetMonHoc(maMonHoc);
            txt_Ma.Enabled = true;
            txt_Ma.Text = monHoc.MaMh.ToString();
            txt_Ma.Enabled = false;
            txt_Ten.Text = monHoc.TenMh;

            txt_CC.Text = monHoc.TschuyenCan.ToString();
            txt_BT.Text = monHoc.TsbaiTap.ToString();
            txt_KT.Text = monHoc.TskiemTra.ToString();
            txt_TH.Text = monHoc.TsthucHanh.ToString();
            txt_Thi.Text = monHoc.Tsthi.ToString();
            inputField_FillTongTS();
            txt_SoTinChi.Text = monHoc.SoTc.ToString();
        }

        private void inputField_FillTongTS()
        {
            int cc = Convert.ToInt32(txt_CC.Text);
            int bt = Convert.ToInt32(txt_BT.Text);
            int kt = Convert.ToInt32(txt_KT.Text);
            int th = Convert.ToInt32(txt_TH.Text);
            int thi = Convert.ToInt32(txt_Thi.Text);

            int tong = cc + bt + kt + th + thi;
            lbl_TongTrongSo.Text = tong.ToString();
        }

        private void inputField_Open()
        {
            dgv_MonHoc.Enabled = false;

            btn_Them.Enabled = btn_Xoa.Enabled = btn_Sua.Enabled = btn_Thoat.Enabled = false;
            btn_XacNhan.Enabled = btn_Huy.Enabled = true;

            lbl_error_Ten.Visible = lbl_error_TS.Visible = lbl_error_SoTinChi.Visible = false;
            txt_Ten.ReadOnly = txt_CC.ReadOnly =
                txt_BT.ReadOnly =
                txt_KT.ReadOnly =
                txt_TH.ReadOnly =
                txt_Thi.ReadOnly =
                txt_SoTinChi.ReadOnly =
                false;
        }

        private void inputField_PrepareForAdd()
        {
            inputField_ClearAllData();
            txt_Ma.Enabled = true;
            txt_Ma.Text = "0";
            txt_Ma.Enabled = false;
        }

        private void txt_BT_KeyPress(object sender, KeyPressEventArgs e) => KeyHandler.CheckErrorKeyPressEvent(sender, lbl_error_TS, e, KeyHandler.NoneSpaceDigitHandler);

        private void txt_BT_Leave(object sender, EventArgs e)
        {
            lbl_error_TS.Visible = false;
            txt_BT.Text = Standardize.NotNullStandardizeNumber(txt_BT.Text);
            inputField_FillTongTS();
        }

        private void txt_CC_KeyPress(object sender, KeyPressEventArgs e) => KeyHandler.CheckErrorKeyPressEvent(sender, lbl_error_TS, e, KeyHandler.NoneSpaceDigitHandler);

        private void txt_CC_Leave(object sender, EventArgs e)
        {
            lbl_error_TS.Visible = false;
            txt_CC.Text = Standardize.NotNullStandardizeNumber(txt_CC.Text);
            inputField_FillTongTS();
        }

        private void txt_KT_KeyPress(object sender, KeyPressEventArgs e) => KeyHandler.CheckErrorKeyPressEvent(sender, lbl_error_TS, e, KeyHandler.NoneSpaceDigitHandler);

        private void txt_KT_Leave(object sender, EventArgs e)
        {
            lbl_error_TS.Visible = false;
            txt_KT.Text = Standardize.NotNullStandardizeNumber(txt_KT.Text);
            inputField_FillTongTS();
        }

        private void txt_SoTinChi_KeyPress(object sender, KeyPressEventArgs e) => KeyHandler.CheckErrorKeyPressEvent(sender, lbl_error_SoTinChi, e, KeyHandler.CreditHandler);

        private void txt_SoTinChi_Leave(object sender, EventArgs e) => lbl_error_SoTinChi.Visible = false;

        private void txt_Ten_KeyPress(object sender, KeyPressEventArgs e) => KeyHandler.CheckErrorKeyPressEvent(sender, lbl_error_Ten, e, KeyHandler.DigitTextHandler);

        private void txt_Ten_Leave(object sender, EventArgs e)
        {
            lbl_error_Ten.Visible = false;
            txt_Ten.Text = Standardize.StandardizeText(txt_Ten.Text);
        }

        private void txt_TH_KeyPress(object sender, KeyPressEventArgs e) => KeyHandler.CheckErrorKeyPressEvent(sender, lbl_error_TS, e, KeyHandler.NoneSpaceDigitHandler);

        private void txt_TH_Leave(object sender, EventArgs e)
        {
            lbl_error_TS.Visible = false;
            txt_TH.Text = Standardize.NotNullStandardizeNumber(txt_TH.Text);
            inputField_FillTongTS();
        }

        private void txt_Thi_KeyPress(object sender, KeyPressEventArgs e) => KeyHandler.CheckErrorKeyPressEvent(sender, lbl_error_TS, e, KeyHandler.NoneSpaceDigitHandler);

        private void txt_Thi_Leave(object sender, EventArgs e)
        {
            lbl_error_TS.Visible = false;
            txt_Thi.Text = Standardize.NotNullStandardizeNumber(txt_Thi.Text);
            inputField_FillTongTS();
        }

        public void form_LoadInitial()
        {
            dgv_MonHoc_FillData();
            inputField_ClearAllData();
            inputField_Close();
            btn_Xoa.Enabled = btn_Sua.Enabled = false;
        }
    }
}