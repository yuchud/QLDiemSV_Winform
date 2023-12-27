using DevExpress.XtraEditors;
using QLDiemSV_Winform.ApiController;
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
    public partial class SubForm_Lay_LopSinhVien : DevExpress.XtraEditors.XtraForm
    {
        public int MaLopSinhVien { get; private set; }
        public string TenLopSinhVien { get; private set; }
        public string TenKhoa { get; private set; }
        public SubForm_Lay_LopSinhVien()
        {
            InitializeComponent();
            cmb_Khoa_FillData();
            form_LoadInitial();
        }


        private void cmb_Khoa_FillData()
        {
            cmb_Khoa.DataSource = KhoaApiController.GetAllKhoa();
            cmb_Khoa.DisplayMember = "tenKhoa";
            cmb_Khoa.ValueMember = "maKhoa";
        }

        private void dgvColumn_Hide(string columeName)
        {
            if (dgv_LopSinhVien.Columns.Contains(columeName))
            {
                dgv_LopSinhVien.Columns[columeName].Visible = false;
            }
        }

        private void dgv_LopSinhVien_FillData(int MaKhoa)
        {
            dgv_LopSinhVien.DataSource = LopSinhVienApiController.GetListLopSinhVienByMaKhoa(MaKhoa);
            dgvColumn_Hide("maKhoa");
            lbl_SoLuong.Text = dgv_LopSinhVien.RowCount.ToString();
            dgv_LopSinhVien.ClearSelection();
        }

        private int dataMaKhoa_Get()
        {
            dynamic khoa = cmb_Khoa.SelectedItem;
            return khoa.MaKhoa;
        }

        private string dataTenKhoa_Get()
        {
            dynamic khoa = cmb_Khoa.SelectedItem;
            return khoa.TenKhoa;
        }

        public void form_LoadInitial()
        {
            dgv_LopSinhVien_FillData(dataMaKhoa_Get());
            btn_XacNhan.Enabled = false;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            MaLopSinhVien = Convert.ToInt32(dgv_LopSinhVien.SelectedRows[0].Cells["maLopSv"].Value);
            TenLopSinhVien = dgv_LopSinhVien.SelectedRows[0].Cells["tenLopSv"].Value.ToString();
            TenKhoa = dataTenKhoa_Get();
            this.Close();
        }

        private void dgv_LopSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_LopSinhVien.SelectedRows.Count > 0)
            {
                btn_XacNhan.Enabled = true;
            }
        }

        private void cmb_Khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            form_LoadInitial();
        }
    }
}