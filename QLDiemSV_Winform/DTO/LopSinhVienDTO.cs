using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV_Winform.DTO
{
    internal class LopSinhVienDTO
    {
        private int maLopSv;
        private string tenLopSv;
        private int maKhoa;
        public LopSinhVienDTO() { }

        public LopSinhVienDTO(int maLopSv, string tenLopSv, int maKhoa)
        {
            this.maLopSv = maLopSv;
            this.tenLopSv = tenLopSv;
            this.maKhoa = maKhoa;
        }

        public int MaLopSv { get => maLopSv; set => maLopSv = value; }
        public string TenLopSv { get => tenLopSv; set => tenLopSv = value; }
        public int MaKhoa { get => maKhoa; set => maKhoa = value; }
    }
}
