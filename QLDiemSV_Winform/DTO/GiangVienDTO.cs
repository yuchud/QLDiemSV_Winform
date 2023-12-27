using Newtonsoft.Json;
using QLDiemSV_Winform.Secure;
using QLDiemSV_Winform.Validation;
using System;
using System.Linq;

namespace QLDiemSV_Winform.DTO
{
    internal class GiangVienDTO
    {
        private int maGv;
        private string ho;
        private String ten;
        private String diaChi;
        private String sdt;
        private int maKhoa;
        private int maQuyen;

        [JsonIgnore]
        private string chucVu;

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
                this.chucVu = "Nhân viên";
            }
            else
            {
                this.chucVu = "Giảng viên";
            }
        }

        public int MaGv { get => maGv; set => maGv = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int MaKhoa { get => maKhoa; set => maKhoa = value; }
        public int MaQuyen { get => maQuyen; set => maQuyen = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
    }
}
