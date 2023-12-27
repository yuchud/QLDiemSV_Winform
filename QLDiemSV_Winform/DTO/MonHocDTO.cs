using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV_Winform.DTO
{
    internal class MonHocDTO
    {
        private int maMh;
        private string tenMh;
        private int tschuyenCan;
        private int tsbaiTap;
        private int tskiemTra;
        private int tsthucHanh;
        private int tsthi;
        private int soTc;

        public MonHocDTO(int maMh, string tenMh, int tschuyenCan, int tsbaiTap, int tskiemTra, int tsthucHanh, int tsthi, int soTc)
        {
            this.MaMh = maMh;
            this.TenMh = tenMh;
            this.TschuyenCan = tschuyenCan;
            this.TsbaiTap = tsbaiTap;
            this.TskiemTra = tskiemTra;
            this.TsthucHanh = tsthucHanh;
            this.Tsthi = tsthi;
            this.SoTc = soTc;
        }

        public int MaMh { get => maMh; set => maMh = value; }
        public string TenMh { get => tenMh; set => tenMh = value; }
        public int TschuyenCan { get => tschuyenCan; set => tschuyenCan = value; }
        public int TsbaiTap { get => tsbaiTap; set => tsbaiTap = value; }
        public int TskiemTra { get => tskiemTra; set => tskiemTra = value; }
        public int TsthucHanh { get => tsthucHanh; set => tsthucHanh = value; }
        public int Tsthi { get => tsthi; set => tsthi = value; }
        public int SoTc { get => soTc; set => soTc = value; }
    }
}
