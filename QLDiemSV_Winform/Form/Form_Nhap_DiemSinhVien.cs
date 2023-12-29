using QLDiemSV_Winform.ApiController;
using QLDiemSV_Winform.DTO;
using QLDiemSV_Winform.Secure;
using QLDiemSV_Winform.Support;
using QLDiemSV_Winform.Validation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace QLDiemSV_Winform.SubForm
{
    public partial class Form_Nhap_DiemSinhVien : DevExpress.XtraEditors.XtraForm
    {

        private static readonly string Action = ConstantValues.ActionEnter;
        private static readonly string Target = ConstantValues.TargetScore;
        public static readonly string FormName = Action + (Action.Length > 0 && Target.Length > 0 ? " " : "") + Target;

        private int maLopTinChi;
        private int maMonHoc;
        bool isReadOnlyCC, isReadOnlyBT, isReadOnlyKT, isReadOnlyTH, isReadOnlyThi;
        public Form_Nhap_DiemSinhVien() { 
            InitializeComponent();
            form_LoadInitial();
        }

        private void btn_Thoat_Click(object sender, EventArgs e) => TabManager.CloseForm(this);

        private List<BangDiemInfoDTO> dataListBangDiem_Create()
        { return BangDiemController.GetListBangDiemByMaLopTinChi(maLopTinChi); }


        private void dgv_BangDiem_Column_SetReadOnly()
        {

            foreach (DataGridViewColumn column in dgv_BangDiem.Columns)
                column.ReadOnly = true;

            dgv_BangDiem.Columns["chuyenCan"].ReadOnly = isReadOnlyCC;
            dgv_BangDiem.Columns["baiTap"].ReadOnly = isReadOnlyBT;
            dgv_BangDiem.Columns["kiemTra"].ReadOnly = isReadOnlyKT;
            dgv_BangDiem.Columns["thucHanh"].ReadOnly = isReadOnlyTH;
            dgv_BangDiem.Columns["thi"].ReadOnly = isReadOnlyThi;

            foreach (DataGridViewColumn column in dgv_BangDiem.Columns)
                if (column.ReadOnly)
                    column.DefaultCellStyle.BackColor = Color.DarkGray;
            dgv_BangDiem.ClearSelection();
        }

        private void dgv_BangDiem_Column_Modify()
        {
            dgv_BangDiem.ReadOnly = true;

            foreach (DataGridViewColumn column in dgv_BangDiem.Columns)
                if (column.ReadOnly)
                    column.DefaultCellStyle.BackColor = Color.White;

            MonHocDTO monhoc = MonHocController.GetMonHoc(maMonHoc);
            DataGridViewManager.HideColumn(dgv_BangDiem, "maBangDiem");
            DataGridViewManager.HideColumn(dgv_BangDiem, "maLopTc");
            if (monhoc == null) return;

            int cc = Convert.ToInt32(monhoc.TschuyenCan);
            int bt = Convert.ToInt32(monhoc.TsbaiTap);
            int kt = Convert.ToInt32(monhoc.TskiemTra);
            int th = Convert.ToInt32(monhoc.TsthucHanh);
            int thi = Convert.ToInt32(monhoc.TschuyenCan);

            isReadOnlyCC = (cc == 0);
            isReadOnlyBT = (bt == 0);
            isReadOnlyKT = (kt == 0);
            isReadOnlyTH = (th == 0);
            isReadOnlyThi = (thi == 0);
            DataGridViewManager.ChangeHeaderText(dgv_BangDiem, "chuyenCan", $"Chuyên cần({cc}%)");
            DataGridViewManager.ChangeHeaderText(dgv_BangDiem, "baiTap", $"Bài tập({bt}%)");
            DataGridViewManager.ChangeHeaderText(dgv_BangDiem, "kiemTra", $"Kiểm tra({kt}%)");
            DataGridViewManager.ChangeHeaderText(dgv_BangDiem, "thucHanh", $"Thực hành({th}%)");
            DataGridViewManager.ChangeHeaderText(dgv_BangDiem, "thi", $"Thi({thi}%)");
        }
        private void dgv_BangDiem_LoadData()
        {
            dgv_BangDiem.DataSource = dataListBangDiem_Create();
            dgv_BangDiem_Column_Modify();
            dgv_BangDiem.ClearSelection();
        }


        private void dgv_BangDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgv_BangDiem.BeginEdit(true);
            }
        }

        private void dgv_BangDiem_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Check if it's a header cell and the associated column is read-only
            if (e.RowIndex == -1 && e.ColumnIndex >= 0 && dgv_BangDiem.Columns[e.ColumnIndex].ReadOnly)
            {
                // Set the header color for read-only columns
                e.CellStyle.BackColor = Color.LightGray;
                e.CellStyle.ForeColor = Color.Black; // Adjust text color as needed
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            
            int rowIndex = -1;
            int columnIndex = -1;
            if (dgv_BangDiem.CurrentCell != null)
            {
                rowIndex = dgv_BangDiem.CurrentCell.RowIndex;
                columnIndex = dgv_BangDiem.CurrentCell.ColumnIndex;
            }
            form_LoadInitial();
            if(rowIndex != -1)
            {
                dgv_BangDiem.CurrentCell = dgv_BangDiem[columnIndex, rowIndex];
            }
        }

        TextBox currentTextboxEdit = null;

        private void dgv_BangDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyHandler.CheckErrorMarkKeyPressEvent(sender, lbl_error_Diem, e, KeyHandler.NoneSpaceDoubleHandler);
        }

        private void dgv_BangDiem_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if(e.Control is TextBox textBox)
            {
                textBox.KeyPress -= dgv_BangDiem_KeyPress;
                textBox.KeyPress += dgv_BangDiem_KeyPress;

                textBox.TextChanged -= textBox_TextChanged;
                textBox.TextChanged += textBox_TextChanged;

                textBox.Leave -= textBox_Leave;
                textBox.Leave += textBox_Leave;

            }
        }


        private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if(textBox.Text == string.Empty)
            {
                textBox.Text = "0";
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            string errorMarkStr = "Điểm chỉ nhận các dạng:\nx (với 0<=x<=9)\nx. (dấu , tự chuyển thành .)\nx.x\n10";
            lbl_error_Diem.Visible = false;
            TextBox textBox = (TextBox)sender;
            string currentMark = textBox.Text;
            DataGridViewCell currentCell = dgv_BangDiem.CurrentCell;

            // kí tự đầu tiên bắt buộc là số
            if (currentMark.Length == 1)
            {
                if (currentMark[0] == ',' || currentMark[0] == '.')
                {
                    lbl_error_Diem.Text = errorMarkStr;
                    lbl_error_Diem.Visible = true;
                    textBox.TextChanged -= textBox_TextChanged;
                    textBox.Text = "";
                    textBox.TextChanged += textBox_TextChanged;
                    textBox.SelectionStart = textBox.Text.Length;
                    textBox.SelectionLength = 0;
                    return;
                }
            }

            if (currentMark.Length == 2)
            {
                char firstDigit = currentMark[0];
                bool isLastDigitNumber = ('0' <= currentMark[1] && currentMark[1] <= '9');
                if (isLastDigitNumber)
                {
                    char secondDigit = currentMark[1];
                    // Nếu kí tự đầu là 0, thay thế bằng số ta nhập
                    if (firstDigit == '0')
                    {
                        textBox.TextChanged -= textBox_TextChanged;
                        textBox.Text = secondDigit.ToString();
                        textBox.TextChanged += textBox_TextChanged;
                        textBox.SelectionStart = textBox.Text.Length;
                        textBox.SelectionLength = 0;
                        return;
                    }
                    // Trường hợp điểm 2 chữ số chỉ có 10
                    if ((firstDigit == '1' && secondDigit == '0') == false)
                    {
                        lbl_error_Diem.Text = errorMarkStr;
                        lbl_error_Diem.Visible = true;
                        textBox.TextChanged -= textBox_TextChanged;
                        textBox.Text = firstDigit.ToString();
                        textBox.TextChanged += textBox_TextChanged;
                        textBox.SelectionStart = textBox.Text.Length;
                        textBox.SelectionLength = 0;
                        return;
                    }

                }
                else
                {
                    // Lúc này chỉ có 2 trường hợp
                    // x, 
                    // x.
                    // 10
                    // Chuyển sang 1 định dạng là x.
                    textBox.TextChanged -= textBox_TextChanged;
                    textBox.Text = firstDigit.ToString() + '.';
                    textBox.TextChanged += textBox_TextChanged;
                    textBox.SelectionStart = textBox.Text.Length;
                    textBox.SelectionLength = 0;
                }
                
            }

            // Lúc này sẽ có 2 trường hợp
            // 10(số)
            // x,(số)
            if (currentMark.Length == 3)
            {
                bool isTen = (currentMark[1] == '0');
                if (isTen)
                {
                    lbl_error_Diem.Text = errorMarkStr;
                    lbl_error_Diem.Visible = true;
                    textBox.TextChanged -= textBox_TextChanged;
                    textBox.Text = "10";
                    textBox.TextChanged += textBox_TextChanged;
                    textBox.SelectionStart = textBox.Text.Length;
                    textBox.SelectionLength = 0;
                    return;
                }
                else
                {
                    bool isLastDigitNumber = ('0' <= currentMark[2] && currentMark[2] <= '9');
                    if(isLastDigitNumber == false)
                    {
                        lbl_error_Diem.Text = errorMarkStr;
                        lbl_error_Diem.Visible = true;
                        textBox.TextChanged -= textBox_TextChanged;
                        textBox.Text = currentMark.Remove(currentMark.Length - 1);
                        textBox.TextChanged += textBox_TextChanged;
                        textBox.SelectionStart = textBox.Text.Length;
                        textBox.SelectionLength = 0;
                        return;
                    }
                }
            }

            // Nếu tới được đây
            // Trường hợp duy nhất là x.x(số)
            if (currentMark.Length == 4)
            {
                lbl_error_Diem.Text = errorMarkStr;
                lbl_error_Diem.Visible = true;
                textBox.TextChanged -= textBox_TextChanged;
                textBox.Text = currentMark.Remove(currentMark.Length - 1);
                textBox.TextChanged += textBox_TextChanged;
                textBox.SelectionStart = textBox.Text.Length;
                textBox.SelectionLength = 0;
            }
            
            
        }
        private void dgv_BangDiem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(currentTextboxEdit != null) Console.WriteLine(currentTextboxEdit.Text);
        }

        private void dgv_BangDiem_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            dgv_BangDiem.Rows[rowIndex].Cells[columnIndex].Value = "0";
        }

        private void form_LoadInitial()
        {
            dgv_BangDiem_LoadData();
            if (maLopTinChi != 0)
                btn_CapNhat.Enabled = true;
            else
                btn_CapNhat.Enabled = false;
            lbl_error_Diem.Visible = false;
            btn_Chon.Enabled = true;
            btn_XacNhan.Enabled = btn_Huy.Enabled = false;
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
                    maMonHoc = subForm_Lay_LopTinChi.MaMH;
                    txt_MonHoc.ReadOnly = txt_Nam.ReadOnly = txt_Ky.ReadOnly = false;
                    txt_Nam.Text = subForm_Lay_LopTinChi.Nam.ToString();
                    txt_MonHoc.Text = SubjectPairGenerator.GetTenMonHoc(subForm_Lay_LopTinChi.MaMH);
                    txt_Ky.Text = subForm_Lay_LopTinChi.Ky.ToString();
                    txt_MonHoc.ReadOnly = txt_Nam.ReadOnly = txt_Ky.ReadOnly = true;
                    form_LoadInitial();
                }
            }
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (MessageBoxManager.OpenMessageBox(Action, Target) == false)
                return;

            foreach (DataGridViewRow dataGridViewRow in dgv_BangDiem.Rows)
            {
                int maBangDiem = Convert.ToInt32(dataGridViewRow.Cells["maBangDiem"].Value);
                int maLopTc = Convert.ToInt32(dataGridViewRow.Cells["maLopTc"].Value);
                int maSv = Convert.ToInt32(dataGridViewRow.Cells["maSv"].Value);
                double chuyenCan = Convert.ToInt32(dataGridViewRow.Cells["chuyenCan"].Value);
                double baiTap = Convert.ToInt32(dataGridViewRow.Cells["baiTap"].Value);
                double kiemTra = Convert.ToInt32(dataGridViewRow.Cells["kiemTra"].Value);
                double thucHanh = Convert.ToInt32(dataGridViewRow.Cells["thucHanh"].Value);
                double thi = Convert.ToInt32(dataGridViewRow.Cells["thi"].Value);
                BangDiemController.PutBangDiem(new BangDiemDTO(maBangDiem, maLopTc, maSv, chuyenCan, baiTap, kiemTra, thucHanh, thi, 0));
            }
            form_LoadInitial();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            btn_CapNhat.Enabled = btn_Chon.Enabled = false;
            dgv_BangDiem.ReadOnly = false;
            dgv_BangDiem_Column_SetReadOnly();
            btn_XacNhan.Enabled = btn_Huy.Enabled = true;
        }
    }
}