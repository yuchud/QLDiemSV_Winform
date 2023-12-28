using System;
using System.Linq;

namespace QLDiemSV_Winform.DTO
{
    internal class BangDiemDTO
    {
        public BangDiemDTO()
        {
        }

        public BangDiemDTO(
            int maBangDiem,
            int maLopTc,
            int maSv,
            double chuyenCan,
            double baiTap,
            double kiemTra,
            double thucHanh,
            double thi,
            double tongKet)
        {
            this.MaBangDiem = maBangDiem;
            this.MaLopTc = maLopTc;
            this.MaSv = maSv;
            this.ChuyenCan = chuyenCan;
            this.BaiTap = baiTap;
            this.KiemTra = kiemTra;
            this.ThucHanh = thucHanh;
            this.Thi = thi;
            this.TongKet = tongKet;
        }

        public int MaBangDiem { get; set; }

        public int MaLopTc { get; set; }

        public int MaSv { get; set; }

        public double ChuyenCan { get; set; }

        public double BaiTap { get; set; }

        public double KiemTra { get; set; }

        public double ThucHanh { get; set; }

        public double Thi { get; set; }


        public double TongKet { get; set; }
    }
}
