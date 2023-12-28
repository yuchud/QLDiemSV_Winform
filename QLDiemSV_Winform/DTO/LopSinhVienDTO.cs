using System;
using System.Linq;

namespace QLDiemSV_Winform.DTO
{
    internal class LopSinhVienDTO
    {
        public LopSinhVienDTO()
        {
        }

        public LopSinhVienDTO(int maLopSv, string tenLopSv, int maKhoa)
        {
            this.MaLopSv = maLopSv;
            this.TenLopSv = tenLopSv;
            this.MaKhoa = maKhoa;
        }

        public int MaKhoa { get; set; }

        public int MaLopSv { get; set; }

        public string TenLopSv { get; set; }
    }
}
