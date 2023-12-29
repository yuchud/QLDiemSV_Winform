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
    internal class SinhVienController
    {
        private static readonly string Api_SinhVien_Url = Program.ApiBaseUrl + "/SinhVien";

        public SinhVienController()
        {
        }

        public static HttpStatusCode DeleteSinhVien(int maSinhVien)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.DeleteAsync($"{Api_SinhVien_Url}/{maSinhVien}")
                    .Result;
                return httpResponse.StatusCode;
            }
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

        public static List<SinhVienDTO> GetListSinhVienByMaLopTinChi(int maLopTinChi)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_SinhVien_Url}/maLopTinChi={maLopTinChi}")
                    .Result;
                if (httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    List<SinhVienDTO> DsSinhVien = JsonConvert.DeserializeObject<List<SinhVienDTO>>(json);
                    return DsSinhVien;
                }
            }
            return null;
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

        public static HttpStatusCode PostSinhVien(SinhVienDTO sinhVien)
        {
            using (var httpClient = new HttpClient())
            {
                string jsonSinhVien = JsonConvert.SerializeObject(sinhVien);
                HttpResponseMessage response = httpClient.PostAsync(
                    $"{Api_SinhVien_Url}",
                    new StringContent(jsonSinhVien, System.Text.Encoding.UTF8, "application/json"))
                    .Result;
                return response.StatusCode;
            }
        }

        public static HttpStatusCode PutSinhVien(SinhVienDTO sinhVien)
        {
            using (var httpClient = new HttpClient())
            {
                string jsonSinhVien = JsonConvert.SerializeObject(sinhVien);
                HttpResponseMessage response = httpClient.PutAsync(
                    $"{Api_SinhVien_Url}/{sinhVien.MaSv}",
                    new StringContent(jsonSinhVien, System.Text.Encoding.UTF8, "application/json"))
                    .Result;
                return response.StatusCode;
            }
        }
    }
}
