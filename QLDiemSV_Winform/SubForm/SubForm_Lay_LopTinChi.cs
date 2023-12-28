using QLDiemSV_Winform.ApiController;
using QLDiemSV_Winform.DTO;
using QLDiemSV_Winform.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QLDiemSV_Winform.SubForm
{
    public partial class SubForm_Lay_LopTinChi : DevExpress.XtraEditors.XtraForm
    {
        bool isOpenDialog;
        private List<LopTinChiDTO> lopTinChiList;

        public SubForm_Lay_LopTinChi(bool isOpenDialog = true)
        {
            InitializeComponent();
            cmb_Nam_LoadData();
            cmb_Ky_LoadData();
            form_LoadInitial();
            this.isOpenDialog = isOpenDialog;
        }

        private void btn_Thoat_Click(object sender, EventArgs e) => this.Close();

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (isOpenDialog == true)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Bạn có chắc chắn chọn lớp tín chỉ này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                    return;
            }
            MaLopTC = Convert.ToInt32(dgv_LopTinChi.SelectedRows[0].Cells["maLopTc"].Value);
            MaMH = Convert.ToInt32(dgv_LopTinChi.SelectedRows[0].Cells["maMh"].Value);
            Nam = Convert.ToInt32(dgv_LopTinChi.SelectedRows[0].Cells["nam"].Value);
            Ky = Convert.ToInt32(dgv_LopTinChi.SelectedRows[0].Cells["ky"].Value);
            this.Close();
        }

        private void cmb_Ky_LoadData() => cmb_Ky.DataSource = new List<string> { "1", "2" };

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

        private void cmb_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lopTinChiList == null)
                return;

            dgv_LopTinChi_LoadData();
        }

        private List<LopTinChiDTO> dataLopTinChi_Create()
        {
            int nam = Convert.ToInt32(cmb_Nam.SelectedItem);
            int ky = Convert.ToInt32(cmb_Ky.SelectedItem);
            List<LopTinChiDTO> currentlopTinChiList = new List<LopTinChiDTO>();
            currentlopTinChiList.AddRange(lopTinChiList.Where(lopTinChi => lopTinChi.Nam == nam && lopTinChi.Ky == ky));
            return currentlopTinChiList;
        }

        private void dgv_LopTinChi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_LopTinChi.SelectedRows.Count > 0)
                btn_XacNhan.Enabled = true;
        }

        private void dgv_LopTinChi_LoadData()
        {
            int nam = Convert.ToInt32(cmb_Nam.SelectedItem);
            lopTinChiList = LopTinChiApiController.GetListLopTinChiByNamHoc(nam);
            foreach (LopTinChiDTO lopTinChi in lopTinChiList)
                lopTinChi.Generate_TenMonHoc();

            dgv_LopTinChi.DataSource = dataLopTinChi_Create();
            DataGridViewManager.HideColumn(dgv_LopTinChi, "maMh");
            DataGridViewManager.HideColumn(dgv_LopTinChi, "nam");
            DataGridViewManager.HideColumn(dgv_LopTinChi, "ky");
            lbl_SoLuong.Text = dgv_LopTinChi.RowCount.ToString();
        }

        private void form_LoadInitial()
        {
            dgv_LopTinChi_LoadData();
            btn_XacNhan.Enabled = false;
        }

        public int Ky { get; private set; }

        public int MaLopTC { get; private set; }

        public int MaMH { get; private set; }

        public int Nam { get; private set; }
    }
}