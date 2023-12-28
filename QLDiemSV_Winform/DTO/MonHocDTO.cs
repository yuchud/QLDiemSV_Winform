using System;
using System.Linq;

namespace QLDiemSV_Winform.DTO
{
    internal class MonHocDTO
    {
        public MonHocDTO(
            int maMh,
            string tenMh,
            int tschuyenCan,
            int tsbaiTap,
            int tskiemTra,
            int tsthucHanh,
            int tsthi,
            int soTc)
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

        public int MaMh { get; set; }

        public int SoTc { get; set; }

        public string TenMh { get; set; }

        public int TsbaiTap { get; set; }

        public int TschuyenCan { get; set; }

        public int TskiemTra { get; set; }

        public int Tsthi { get; set; }

        public int TsthucHanh { get; set; }
    }
}
