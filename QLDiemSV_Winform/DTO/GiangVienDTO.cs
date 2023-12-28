using Newtonsoft.Json;
using QLDiemSV_Winform.Secure;
using QLDiemSV_Winform.Validation;
using System;
using System.Linq;

namespace QLDiemSV_Winform.DTO
{
    internal class GiangVienDTO
    {
        public GiangVienDTO()
        {
        }

        public GiangVienDTO(int maGv, string ho, string ten, string diaChi, string sdt, int maKhoa, int maQuyen)
        {
            this.MaGv = maGv;
            this.Ho = ho;
            this.Ten = ten;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
            this.MaKhoa = maKhoa;
            this.MaQuyen = maQuyen;
        }

        public void GenerateChucVu()
        {
            if (TeacherDecentralization.GetQuyenGiangVien(this.MaQuyen) == EnumCode.Decentralization.NhanVien)
            {
                this.ChucVu = "Nhân viên";
            } else
            {
                this.ChucVu = "Giảng viên";
            }
        }

        public int MaGv { get; set; }

        public string Ho { get; set; }

        public string Ten { get; set; }

        public string DiaChi { get; set; }

        public string Sdt { get; set; }

        public int MaKhoa { get; set; }

        public int MaQuyen { get; set; }

        [JsonIgnore]
        public string ChucVu { get; set; }
    }
}
