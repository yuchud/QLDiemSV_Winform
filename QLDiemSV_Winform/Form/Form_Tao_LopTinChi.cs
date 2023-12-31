﻿using QLDiemSV_Winform.ApiController;
using QLDiemSV_Winform.DTO;
using QLDiemSV_Winform.SubForm;
using QLDiemSV_Winform.Support;
using QLDiemSV_Winform.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace QLDiemSV_Winform.Form
{
    public partial class Form_Tao_LopTinChi : DevExpress.XtraEditors.XtraForm
    {
        private static readonly string Action = ConstantValues.ActionCreate;
        private static readonly string Target = ConstantValues.TargetCreditClass;
        public static readonly string FormName = Action + (Action.Length > 0 && Target.Length > 0 ? " " : "") + Target;
        private List<LopTinChiDTO> lopTinChiList;

        public Form_Tao_LopTinChi()
        {
            InitializeComponent();
            cmb_Nam_LoadData();
            cmb_Ky_LoadData();
            form_LoadInitial();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            using (SubForm_Lay_MonHoc subForm_Lay_MonHoc = new SubForm_Lay_MonHoc(exclusionSubjectsIdList_Create()))
            {
                subForm_Lay_MonHoc.FormBorderStyle = FormBorderStyle.None;
                subForm_Lay_MonHoc.ShowDialog();
                int maMonHoc = subForm_Lay_MonHoc.MaMonHoc;
                if (maMonHoc != 0)
                {
                    if (MessageBoxManager.ShowResult(LopTinChiController.PostLopTinChi(dataLopTinChi_Create(maMonHoc)), Action, Target)) form_LoadInitial();
                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e) => TabManager.CloseForm(this);

        private (bool canDelete, string error) btn_Xoa_CheckBeforeDelete(int maLopTinChi)
        {
            if (BangDiemController.GetListBangDiemByMaLopTinChi(maLopTinChi).Count > 0)
                return (false, "Không thể xóa lớp tín chỉ đã có bảng điểm");
            return (true, string.Empty);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int maLopTinChi = Convert.ToInt32(dgv_LopTinChi.SelectedRows[0].Cells["maLopTc"].Value);

            (bool canDelete, string error) = btn_Xoa_CheckBeforeDelete(maLopTinChi);

            if (canDelete == false)
            {
                MessageBox.Show(error);
                return;
            }

            if (MessageBoxManager.OpenMessageBox(ConstantValues.ActionDelete, Target) == false) return;

            if (MessageBoxManager.ShowResult(LopTinChiController.DeleteLopTinChi(maLopTinChi), ConstantValues.ActionDelete, Target)) form_LoadInitial();
        }

        private void cmb_Khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lopTinChiList == null)
                return;

            dgv_LopTinChi_LoadData();
        }

        private void cmb_Ky_LoadData() { cmb_Ky.DataSource = new List<string> { "1", "2" }; }

        private void cmb_Ky_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lopTinChiList == null)
                return;
            dgv_LopTinChi_LoadData();
        }

        private void cmb_Nam_LoadData()
        {
            List<string> yearsList = new List<string>();
            for (int year = ConstantValues.minYear; year <= ConstantValues.maxYear; year++)
                yearsList.Add(year.ToString());
            cmb_Nam.DataSource = yearsList;
        }

        private List<LopTinChiDTO> dataLopTinChi_Create()
        {
            int nam = Convert.ToInt32(cmb_Nam.SelectedItem);
            int ky = Convert.ToInt32(cmb_Ky.SelectedItem);
            List<LopTinChiDTO> currentlopTinChiList = new List<LopTinChiDTO>();
            foreach (LopTinChiDTO lopTinChi in lopTinChiList)
                if (lopTinChi.Nam == nam && lopTinChi.Ky == ky)
                    currentlopTinChiList.Add(lopTinChi);
            return currentlopTinChiList;
        }

        private LopTinChiDTO dataLopTinChi_Create(int maMonHoc)
        {
            int nam = Convert.ToInt32(cmb_Nam.SelectedItem);
            int ky = Convert.ToInt32(cmb_Ky.SelectedItem);
            return new LopTinChiDTO(0, maMonHoc, nam, ky);
        }

        private void dgv_LopTinChi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_LopTinChi.SelectedRows.Count > 0)
                btn_Xoa.Enabled = true;
        }

        private void dgv_LopTinChi_LoadData()
        {
            int nam = Convert.ToInt32(cmb_Nam.SelectedItem);
            lopTinChiList = LopTinChiController.GetListLopTinChiByNamHoc(nam);
            foreach (LopTinChiDTO lopTinChi in lopTinChiList)
                lopTinChi.Generate_TenMonHoc();

            dgv_LopTinChi.DataSource = dataLopTinChi_Create();
            DataGridViewManager.HideColumn(dgv_LopTinChi, "maMh");
            DataGridViewManager.HideColumn(dgv_LopTinChi, "nam");
            DataGridViewManager.HideColumn(dgv_LopTinChi, "ky");
            lbl_SoLuong.Text = dgv_LopTinChi.RowCount.ToString();
        }

        private List<int> exclusionSubjectsIdList_Create()
        {
            List<LopTinChiDTO> lopTinChiList = dataLopTinChi_Create();
            List<int> exclusionSubjectsIdList = new List<int>();
            exclusionSubjectsIdList.AddRange(lopTinChiList.Select(lopTinChi => lopTinChi.MaMh));
            return exclusionSubjectsIdList;
        }

        private void form_LoadInitial()
        {
            btn_Xoa.Enabled = false;
            dgv_LopTinChi_LoadData();
        }
    }
}