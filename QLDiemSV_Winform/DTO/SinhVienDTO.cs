using System;
using System.Linq;

namespace QLDiemSV_Winform.DTO
{
    internal class SinhVienDTO
    {
        public SinhVienDTO()
        {
        }

        public SinhVienDTO(int maSv, string ho, string ten, string diaChi, string sdt, int maLopSv)
        {
            this.MaSv = maSv;
            this.Ho = ho;
            this.Ten = ten;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
            this.MaLopSv = maLopSv;
        }

        public int MaSv { get; set; }

        public string Ho { get; set; }

        public string Ten { get; set; }

        public string DiaChi { get; set; }

        public string Sdt { get; set; }

        public int MaLopSv { get; set; }
    }
}
