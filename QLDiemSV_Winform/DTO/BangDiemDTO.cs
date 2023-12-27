using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV_Winform.DTO
{
    internal class BangDiemDTO
    {
        private int maBangDiem;
        private int maLopTc;
        private int maSv;
        private double chuyenCan;
        private double baiTap;
        private double kiemTra;
        private double thucHanh;
        private double thi;
        private double tongKet;
        public BangDiemDTO() { }

        public BangDiemDTO(int maBangDiem, int maLopTc, int maSv, double chuyenCan, double baiTap, double kiemTra, double thucHanh, double thi, double tongKet)
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

        public int MaBangDiem { get => maBangDiem; set => maBangDiem = value; }
        public int MaLopTc { get => maLopTc; set => maLopTc = value; }
        public int MaSv { get => maSv; set => maSv = value; }
        public double ChuyenCan { get => chuyenCan; set => chuyenCan = value; }
        public double BaiTap { get => baiTap; set => baiTap = value; }
        public double KiemTra { get => kiemTra; set => kiemTra = value; }
        public double ThucHanh { get => thucHanh; set => thucHanh = value; }
        public double Thi { get => thi; set => thi = value; }
        public double TongKet { get => tongKet; set => tongKet = value; }
    }
}
