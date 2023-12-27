using Newtonsoft.Json;
using QLDiemSV_Winform.ApiController;
using QLDiemSV_Winform.Secure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV_Winform.DTO
{
    internal class LopTinChiDTO
    {
        private int maLopTc;
        private int maMh;
        private int nam;
        private int ky;
        [JsonIgnore]
        private string tenMh;

        public void Generate_TenMonHoc()
        {
            TenMh = SubjectPairGenerator.GetTenMonHoc(maMh);
        }
        public LopTinChiDTO() { }

        public LopTinChiDTO(int maLopTc, int maMh, int nam, int ky)
        {
            this.maLopTc = maLopTc;
            this.maMh = maMh;
            this.nam = nam;
            this.ky = ky;
        }

        public int MaLopTc { get => maLopTc; set => maLopTc = value; }
        public int MaMh { get => maMh; set => maMh = value; }
        public int Nam { get => nam; set => nam = value; }
        public int Ky { get => ky; set => ky = value; }
        public string TenMh { get => tenMh; set => tenMh = value; }
    }
}
