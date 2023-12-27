using Newtonsoft.Json;
using QLDiemSV_Winform.DTO;
using QLDiemSV_Winform.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV_Winform.Controller
{
    internal class GiangVienApiController
    {
        private static readonly string Api_GiangVien_Url = Program.ApiBaseUrl + "/GiangVien";

        public GiangVienApiController()
        {
        }
        public static GiangVienDTO GetGiangVien(int maGiangVien)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_GiangVien_Url}/{maGiangVien}").Result;
                if (httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    GiangVienDTO GiangVien = JsonConvert.DeserializeObject<GiangVienDTO>(json);

                    return GiangVien;
                }
            }
            return null;
        }


        public static List<GiangVienDTO> GetListGiangVienByMaKhoa(int MaKhoa)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_GiangVien_Url}/maKhoa={MaKhoa}").Result;
                if (httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    List<GiangVienDTO> DsGiangVien = JsonConvert.DeserializeObject<List<GiangVienDTO>>(json);
                    foreach (GiangVienDTO giangVien in DsGiangVien)
                    {
                        giangVien.GenerateChucVu();
                    }
                    return DsGiangVien;
                }
            }
            return null;
        }

        public static HttpStatusCode PostGiangVien(GiangVienDTO giangVien)
        {
            using (var httpClient = new HttpClient())
            {
                string jsonGiangVien = JsonConvert.SerializeObject(giangVien);
                HttpResponseMessage response = httpClient.PostAsync($"{Api_GiangVien_Url}", new StringContent(jsonGiangVien, System.Text.Encoding.UTF8, "application/json")).Result;
                return response.StatusCode;
            }
        }

        public static HttpStatusCode PutGiangVien(GiangVienDTO giangVien)
        {
            using (var httpClient = new HttpClient())
            {
                string jsonGiangVien = JsonConvert.SerializeObject(giangVien);
                HttpResponseMessage response = httpClient.PutAsync($"{Api_GiangVien_Url}", new StringContent(jsonGiangVien, System.Text.Encoding.UTF8, "application/json")).Result;
                return response.StatusCode;
            }
        }

        public static HttpStatusCode PutMatKhau(TaiKhoanDTO taiKhoan)
        {
            using (var httpClient = new HttpClient())
            {
                string jsonTaiKhoan = JsonConvert.SerializeObject(taiKhoan);
                HttpResponseMessage response = httpClient.PutAsync($"{Api_GiangVien_Url}/matKhau", new StringContent(jsonTaiKhoan, System.Text.Encoding.UTF8, "application/json")).Result;
                return response.StatusCode;
            }
        }


        public static EnumCode.ApiDeleteResult DeleteGiangVien(int maGiangVien)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    HttpResponseMessage httpResponse = httpClient.DeleteAsync($"{Api_GiangVien_Url}/{maGiangVien}").Result;
                    return httpResponse.IsSuccessStatusCode || httpResponse.StatusCode == HttpStatusCode.NoContent ? EnumCode.ApiDeleteResult.Success : EnumCode.ApiDeleteResult.Failure;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions or log errors as needed
                Console.WriteLine($"Error deleting teacher: {ex.Message}");
                return EnumCode.ApiDeleteResult.Failure;
            }
        }
    }
}
