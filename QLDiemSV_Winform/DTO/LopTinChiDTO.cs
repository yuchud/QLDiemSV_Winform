using Newtonsoft.Json;
using QLDiemSV_Winform.Secure;
using System;
using System.Linq;

namespace QLDiemSV_Winform.DTO
{
    internal class LopTinChiDTO
    {
        public LopTinChiDTO()
        {
        }

        public LopTinChiDTO(int maLopTc, int maMh, int nam, int ky)
        {
            this.MaLopTc = maLopTc;
            this.MaMh = maMh;
            this.Nam = nam;
            this.Ky = ky;
        }


        public void Generate_TenMonHoc() { TenMh = SubjectPairGenerator.GetTenMonHoc(MaMh); }

        public int Ky { get; set; }

        public int MaLopTc { get; set; }

        public int MaMh { get; set; }

        public int Nam { get; set; }

[JsonIgnore]
        public string TenMh { get; set; }
    }
}
