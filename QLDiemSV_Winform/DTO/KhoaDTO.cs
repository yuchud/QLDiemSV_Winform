using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV_Winform.DTO
{
    internal class KhoaDTO
    {
        private int maKhoa;
        private string tenKhoa;
        public KhoaDTO() { }

        public KhoaDTO(string maKhoa, string tenKhoa)
        {
            this.maKhoa = Convert.ToInt32(maKhoa);
            this.tenKhoa = tenKhoa;
        }

        public int MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string TenKhoa { get => tenKhoa; set => tenKhoa = value; }
    }
}
