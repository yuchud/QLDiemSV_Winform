using Newtonsoft.Json;
using QLDiemSV_Winform.DTO;
using QLDiemSV_Winform.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV_Winform.Secure
{
    internal class SubjectPairGenerator
    {
        private static readonly string Api_MonHoc = Program.ApiBaseUrl + "/MonHoc";
        private static Dictionary<int, string> pairMonHoc = pairMonHoc_GetFromApi();

        private static Dictionary<int, string> pairMonHoc_GetFromApi()
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_MonHoc}").Result;
                if (httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    List<MonHocDTO> listMonHoc = JsonConvert.DeserializeObject<List<MonHocDTO>>(json);
                    Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
                    foreach (MonHocDTO monHoc in listMonHoc)
                    {
                        int maMonHoc = monHoc.MaMh;
                        string tenMonHoc = monHoc.TenMh;
                        keyValuePairs.Add(maMonHoc, tenMonHoc);

                    }
                    return keyValuePairs;
                }
            }
            return null;
        }

        public static void Reload()
        {
            pairMonHoc = pairMonHoc_GetFromApi();
        }

        public static string GetTenMonHoc(int maMonHoc)
        {
            return pairMonHoc[maMonHoc];
        }

    }
}
