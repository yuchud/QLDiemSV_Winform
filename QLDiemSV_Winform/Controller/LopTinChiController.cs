﻿using Newtonsoft.Json;
using QLDiemSV_Winform.DTO;
using QLDiemSV_Winform.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace QLDiemSV_Winform.ApiController
{
    internal class LopTinChiController
    {
        private static readonly string Api_LopTinChi_Url = Program.ApiBaseUrl + "/LopTinChi";

        public LopTinChiController()
        {
        }

        public static HttpStatusCode DeleteLopTinChi(int maLopTinChi)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.DeleteAsync($"{Api_LopTinChi_Url}/{maLopTinChi}")
                    .Result;
                return httpResponse.StatusCode;
            }
        }


        public static List<LopTinChiDTO> GetListLopTinChi()
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_LopTinChi_Url}").Result;
                if (httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    List<LopTinChiDTO> DsLopTinChi = JsonConvert.DeserializeObject<List<LopTinChiDTO>>(json);
                    return DsLopTinChi;
                }
            }
            return null;
        }

        public static List<LopTinChiDTO> GetListLopTinChiByMaMonHoc(int maMh)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_LopTinChi_Url}/maMonHoc={maMh}").Result;
                if (httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    List<LopTinChiDTO> DsLopTinChi = JsonConvert.DeserializeObject<List<LopTinChiDTO>>(json);
                    return DsLopTinChi;
                }
            }
            return null;
        }

        public static List<LopTinChiDTO> GetListLopTinChiByNamHoc(int namHoc)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_LopTinChi_Url}/namHoc={namHoc}").Result;
                if (httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    List<LopTinChiDTO> DsLopTinChi = JsonConvert.DeserializeObject<List<LopTinChiDTO>>(json);
                    return DsLopTinChi;
                }
            }
            return null;
        }

        public static LopTinChiDTO GetLopTinChi(int maLopTinChi)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_LopTinChi_Url}/{maLopTinChi}").Result;
                if (httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    LopTinChiDTO LopTinChi = JsonConvert.DeserializeObject<LopTinChiDTO>(json);

                    return LopTinChi;
                }
            }
            return null;
        }

        public static HttpStatusCode PostLopTinChi(LopTinChiDTO lopTinChi)
        {
            using (var httpClient = new HttpClient())
            {
                string jsonLopTinChi = JsonConvert.SerializeObject(lopTinChi);
                HttpResponseMessage response = httpClient.PostAsync(
                    $"{Api_LopTinChi_Url}",
                    new StringContent(jsonLopTinChi, System.Text.Encoding.UTF8, "application/json"))
                    .Result;
                return response.StatusCode;
            }
        }

        public static HttpStatusCode PutLopTinChi(LopTinChiDTO lopTinChi)
        {
            using (var httpClient = new HttpClient())
            {
                string jsonLopTinChi = JsonConvert.SerializeObject(lopTinChi);
                HttpResponseMessage response = httpClient.PutAsync(
                    $"{Api_LopTinChi_Url}/{lopTinChi.MaLopTc}",
                    new StringContent(jsonLopTinChi, System.Text.Encoding.UTF8, "application/json"))
                    .Result;
                return response.StatusCode;
            }
        }
    }
}
