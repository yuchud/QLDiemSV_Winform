using Newtonsoft.Json;
using QLDiemSV_Winform.Secure;
using QLDiemSV_Winform.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV_Winform.DTO
{
    internal class SinhVienDTO
    {
        private int maSv;
        private string ho;
        private String ten;
        private String diaChi;
        private String sdt;
        private int maLopSv;
        [JsonIgnore]
        private string tenLopSv;
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

        public int MaSv { get => maSv; set => maSv = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int MaLopSv { get => maLopSv; set => maLopSv = value; }
    }
}
