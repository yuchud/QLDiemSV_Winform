using Newtonsoft.Json;
using QLDiemSV_Winform.DTO;
using QLDiemSV_Winform.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV_Winform.ApiController
{
    internal class SinhVienApiController
    {
        private static readonly string Api_SinhVien_Url = Program.ApiBaseUrl + "/SinhVien";

        public SinhVienApiController()
        {
        }
        public static SinhVienDTO GetSinhVien(int maSinhVien)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_SinhVien_Url}/{maSinhVien}").Result;
                if (httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    SinhVienDTO SinhVien = JsonConvert.DeserializeObject<SinhVienDTO>(json);

                    return SinhVien;
                }
            }
            return null;
        }


        public static List<SinhVienDTO> GetListSinhVienByMaLopSinhVien(int maLopSV)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_SinhVien_Url}/maLopSV={maLopSV}").Result;
                if (httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    List<SinhVienDTO> DsSinhVien = JsonConvert.DeserializeObject<List<SinhVienDTO>>(json);
                    return DsSinhVien;
                }
            }
            return null;
        }

        public static HttpStatusCode PostSinhVien(SinhVienDTO sinhVien)
        {
            using (var httpClient = new HttpClient())
            {
                string jsonSinhVien = JsonConvert.SerializeObject(sinhVien);
                HttpResponseMessage response = httpClient.PostAsync($"{Api_SinhVien_Url}", new StringContent(jsonSinhVien, System.Text.Encoding.UTF8, "application/json")).Result;
                return response.StatusCode;
            }
        }

        public static HttpStatusCode PutSinhVien(SinhVienDTO sinhVien)
        {
            using (var httpClient = new HttpClient())
            {
                string jsonSinhVien = JsonConvert.SerializeObject(sinhVien);
                HttpResponseMessage response = httpClient.PutAsync($"{Api_SinhVien_Url}/{sinhVien.MaSv}", new StringContent(jsonSinhVien, System.Text.Encoding.UTF8, "application/json")).Result;
                return response.StatusCode;
            }
        }

        public static EnumCode.ApiDeleteResult DeleteSinhVien(int maSinhVien)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    HttpResponseMessage httpResponse = httpClient.DeleteAsync($"{Api_SinhVien_Url}/{maSinhVien}").Result;
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
