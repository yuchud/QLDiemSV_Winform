using Newtonsoft.Json;
using QLDiemSV_Winform.DTO;
using QLDiemSV_Winform.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace QLDiemSV_Winform.ApiController
{
    internal class MonHocApiController
    {
        private static readonly string Api_MonHoc_Url = Program.ApiBaseUrl + "/MonHoc";

        public MonHocApiController()
        {
        }

        public static EnumCode.ApiDeleteResult DeleteMonHoc(int maMonHoc)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    HttpResponseMessage httpResponse = httpClient.DeleteAsync($"{Api_MonHoc_Url}/{maMonHoc}").Result;
                    return httpResponse.IsSuccessStatusCode || httpResponse.StatusCode == HttpStatusCode.NoContent
                        ? EnumCode.ApiDeleteResult.Success
                        : EnumCode.ApiDeleteResult.Failure;
                }
            } catch (Exception ex)
            {
                // Handle exceptions or log errors as needed
                Console.WriteLine($"Error deleting Mon Hoc: {ex.Message}");
                return EnumCode.ApiDeleteResult.Failure;
            }
        }

        public static List<MonHocDTO> GetListMonHoc()
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_MonHoc_Url}").Result;
                if (httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    List<MonHocDTO> DsMonHoc = JsonConvert.DeserializeObject<List<MonHocDTO>>(json);
                    return DsMonHoc;
                }
            }
            return null;
        }

        public static MonHocDTO GetMonHoc(int maMonHoc)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_MonHoc_Url}/{maMonHoc}").Result;
                if (httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    MonHocDTO MonHoc = JsonConvert.DeserializeObject<MonHocDTO>(json);

                    return MonHoc;
                }
            }
            return null;
        }


        public static HttpStatusCode PostMonHoc(MonHocDTO monHoc)
        {
            using (var httpClient = new HttpClient())
            {
                string jsonMonHoc = JsonConvert.SerializeObject(monHoc);
                HttpResponseMessage response = httpClient.PostAsync(
                    $"{Api_MonHoc_Url}",
                    new StringContent(jsonMonHoc, System.Text.Encoding.UTF8, "application/json"))
                    .Result;
                return response.StatusCode;
            }
        }

        public static HttpStatusCode PutMonHoc(MonHocDTO monHoc)
        {
            using (var httpClient = new HttpClient())
            {
                string jsonMonHoc = JsonConvert.SerializeObject(monHoc);
                HttpResponseMessage response = httpClient.PutAsync(
                    $"{Api_MonHoc_Url}/{monHoc.MaMh}",
                    new StringContent(jsonMonHoc, System.Text.Encoding.UTF8, "application/json"))
                    .Result;
                return response.StatusCode;
            }
        }
    }
}
