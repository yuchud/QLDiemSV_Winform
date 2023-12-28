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
    internal class KhoaApiController
    {
        private static readonly string Api_Khoa_Url = Program.ApiBaseUrl + "/Khoa";

        public KhoaApiController()
        {
        }

        public static EnumCode.ApiDeleteResult DeleteKhoa(int maKhoa)
        {
            try
            {
                using(var httpClient = new HttpClient())
                {
                    HttpResponseMessage httpResponse = httpClient.DeleteAsync($"{Api_Khoa_Url}/{maKhoa}").Result;
                    return httpResponse.IsSuccessStatusCode || httpResponse.StatusCode == HttpStatusCode.NoContent
                        ? EnumCode.ApiDeleteResult.Success
                        : EnumCode.ApiDeleteResult.Failure;
                }
            } catch(Exception ex)
            {
                // Handle exceptions or log errors as needed
                Console.WriteLine($"Error deleting Khoa: {ex.Message}");
                return EnumCode.ApiDeleteResult.Failure;
            }
        }


        public static List<KhoaDTO> GetAllKhoa()
        {
            try
            {
                using(var httpClient = new HttpClient())
                {
                    HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_Khoa_Url}").Result;
                    if(httpResponse.IsSuccessStatusCode)
                    {
                        string json = httpResponse.Content.ReadAsStringAsync().Result;
                        return JsonConvert.DeserializeObject<List<KhoaDTO>>(json);
                    }
                    return null;
                }
            } catch(Exception ex)
            {
                Console.WriteLine($"Error Get all Khoa: {ex.Message}");
                return null;
            }
        }

        public static KhoaDTO GetKhoa(int maKhoa)
        {
            using(var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_Khoa_Url}/{maKhoa}").Result;
                if(httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    KhoaDTO Khoa = JsonConvert.DeserializeObject<KhoaDTO>(json);

                    return Khoa;
                }
            }
            return null;
        }

        public static HttpStatusCode PostKhoa(KhoaDTO Khoa)
        {
            using(var httpClient = new HttpClient())
            {
                string jsonKhoa = JsonConvert.SerializeObject(Khoa);
                HttpResponseMessage response = httpClient.PostAsync(
                    $"{Api_Khoa_Url}",
                    new StringContent(jsonKhoa, System.Text.Encoding.UTF8, "application/json"))
                    .Result;
                return response.StatusCode;
            }
        }

        public static HttpStatusCode PutKhoa(KhoaDTO Khoa)
        {
            using(var httpClient = new HttpClient())
            {
                string jsonKhoa = JsonConvert.SerializeObject(Khoa);
                HttpResponseMessage response = httpClient.PutAsync(
                    $"{Api_Khoa_Url}/{Khoa.MaKhoa}",
                    new StringContent(jsonKhoa, System.Text.Encoding.UTF8, "application/json"))
                    .Result;
                return response.StatusCode;
            }
        }
    }
}
