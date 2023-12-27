using Newtonsoft.Json;
using QLDiemSV_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV_Winform.Support
{
    internal class StudentClassPairGenerator
    {
        private static readonly string Api_LopSinhVien = Program.ApiBaseUrl + "/LopSv";
        private static Dictionary<int, string> pairLopSinhVien = pairLopSinhVien_GetFromApi();
        StudentClassPairGenerator() { }
        private static Dictionary<int, string> pairLopSinhVien_GetFromApi()
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_LopSinhVien}").Result;
                if (httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    List<LopSinhVienDTO> listLopSinhVien = JsonConvert.DeserializeObject<List<LopSinhVienDTO>>(json);
                    Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
                    foreach (LopSinhVienDTO LopSinhVien in listLopSinhVien)
                    {
                        int maLopSinhVien = LopSinhVien.MaLopSv;
                        string tenLopSinhVien = LopSinhVien.TenLopSv;
                        keyValuePairs.Add(maLopSinhVien, tenLopSinhVien);

                    }
                    return keyValuePairs;
                }
            }
            return null;
        }

        public static void Reload()
        {
            pairLopSinhVien = pairLopSinhVien_GetFromApi();
        }

        public static string GetTenLopSinhVien(int maLopSinhVien)
        {
            return pairLopSinhVien[maLopSinhVien];
        }
    }
}
