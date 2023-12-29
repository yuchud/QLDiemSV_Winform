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
    internal class LopSinhVienController
    {
        private static readonly string Api_LopSinhVien_Url = Program.ApiBaseUrl + "/LopSv";

        public LopSinhVienController()
        {
        }

        public static HttpStatusCode DeleteLopSinhVien(int maLopSinhVien)
        {
            using(var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.DeleteAsync($"{Api_LopSinhVien_Url}/{maLopSinhVien}")
                    .Result;
                return httpResponse.StatusCode;
            }
        }


        public static List<LopSinhVienDTO> GetListLopSinhVienByMaKhoa(int MaKhoa)
        {
            using(var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_LopSinhVien_Url}/maKhoa={MaKhoa}").Result;
                if(httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    List<LopSinhVienDTO> DsLopSinhVien = JsonConvert.DeserializeObject<List<LopSinhVienDTO>>(json);
                    return DsLopSinhVien;
                }
            }
            return null;
        }

        public static LopSinhVienDTO GetLopSinhVien(int maLopSinhVien)
        {
            using(var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_LopSinhVien_Url}/{maLopSinhVien}").Result;
                if(httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    LopSinhVienDTO LopSinhVien = JsonConvert.DeserializeObject<LopSinhVienDTO>(json);

                    return LopSinhVien;
                }
            }
            return null;
        }

        public static HttpStatusCode PostLopSinhVien(LopSinhVienDTO lopSinhVien)
        {
            using(var httpClient = new HttpClient())
            {
                string jsonLopSinhVien = JsonConvert.SerializeObject(lopSinhVien);
                HttpResponseMessage response = httpClient.PostAsync(
                    $"{Api_LopSinhVien_Url}",
                    new StringContent(jsonLopSinhVien, System.Text.Encoding.UTF8, "application/json"))
                    .Result;
                return response.StatusCode;
            }
        }

        public static HttpStatusCode PutLopSinhVien(LopSinhVienDTO lopSinhVien)
        {
            using(var httpClient = new HttpClient())
            {
                string jsonLopSinhVien = JsonConvert.SerializeObject(lopSinhVien);
                HttpResponseMessage response = httpClient.PutAsync(
                    $"{Api_LopSinhVien_Url}/{lopSinhVien.MaLopSv}",
                    new StringContent(jsonLopSinhVien, System.Text.Encoding.UTF8, "application/json"))
                    .Result;
                return response.StatusCode;
            }
        }
    }
}
