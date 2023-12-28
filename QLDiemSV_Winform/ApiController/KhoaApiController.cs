using Newtonsoft.Json;
using QLDiemSV_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace QLDiemSV_Winform.ApiController
{
    internal class KhoaApiController
    {
        private static readonly string Api_Khoa_Url = Program.ApiBaseUrl + "/Khoa";

        public KhoaApiController()
        {
        }


        public static List<KhoaDTO> GetAllKhoa()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_Khoa_Url}").Result;
                    if (httpResponse.IsSuccessStatusCode)
                    {
                        string json = httpResponse.Content.ReadAsStringAsync().Result;
                        return JsonConvert.DeserializeObject<List<KhoaDTO>>(json);
                    }
                    return null;
                }
            } catch (Exception ex)
            {
                Console.WriteLine($"Error Get all Khoa: {ex.Message}");
                return null;
            }
        }
    }
}
