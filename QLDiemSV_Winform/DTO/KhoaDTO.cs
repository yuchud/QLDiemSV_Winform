using System;
using System.Linq;

namespace QLDiemSV_Winform.DTO
{
    internal class KhoaDTO
    {
        public KhoaDTO()
        {
        }

        public KhoaDTO(int maKhoa, string tenKhoa)
        {
            this.MaKhoa = maKhoa;
            this.TenKhoa = tenKhoa;
        }

        public int MaKhoa { get; set; }

        public string TenKhoa { get; set; }
    }
}
