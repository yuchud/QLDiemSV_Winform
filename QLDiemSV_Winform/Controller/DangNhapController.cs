using DevExpress.XtraPrinting.BarCode;
using Newtonsoft.Json;
using QLDiemSV_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV_Winform.ApiController
{
    internal class DangNhapController
    {
        private static readonly string Api_DangNhap_Url = Program.ApiBaseUrl + "/Login";

        public static string PostDangNhap(string tenDangNhap, string matKhau)
        {
            using (var httpClient = new HttpClient())
            {
                string jsonGiangVien = JsonConvert.SerializeObject(new TaiKhoanDTO(tenDangNhap, matKhau));
                HttpResponseMessage response = httpClient.PostAsync(
                    $"{Api_DangNhap_Url}/GiangVien",
                    new StringContent(jsonGiangVien, System.Text.Encoding.UTF8, "application/json"))
                    .Result;
                return response.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
