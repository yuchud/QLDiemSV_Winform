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
    internal class BangDiemController
    {
        private static readonly string Api_BangDiem_Url = Program.ApiBaseUrl + "/BangDiem";

        public BangDiemController()
        {
        }

        public static EnumCode.ApiDeleteResult DeleteBangDiem(int maBangDiem)
        {
            try
            {
                using(var httpClient = new HttpClient())
                {
                    HttpResponseMessage httpResponse = httpClient.DeleteAsync($"{Api_BangDiem_Url}/{maBangDiem}").Result;
                    return httpResponse.IsSuccessStatusCode || httpResponse.StatusCode == HttpStatusCode.NoContent
                        ? EnumCode.ApiDeleteResult.Success
                        : EnumCode.ApiDeleteResult.Failure;
                }
            } catch(Exception ex)
            {
                // Handle exceptions or log errors as needed
                Console.WriteLine($"Error deleting BangDiem: {ex.Message}");
                return EnumCode.ApiDeleteResult.Failure;
            }
        }


        public static HttpStatusCode DeleteBangDiem(int maLopTC, int maSv)
        {
            using(var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.DeleteAsync(
                    $"{Api_BangDiem_Url}/maloptc={maLopTC}&masv={maSv}")
                    .Result;
                return httpResponse.StatusCode;
            }
        }


        public static BangDiemDTO GetBangDiem(int maBangDiem)
        {
            using(var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_BangDiem_Url}/{maBangDiem}").Result;
                if(httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    BangDiemDTO BangDiem = JsonConvert.DeserializeObject<BangDiemDTO>(json);

                    return BangDiem;
                }
            }
            return null;
        }


        public static List<BangDiemInfoDTO> GetListBangDiemByMaLopTinChi(int maLopTc)
        {
            using(var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_BangDiem_Url}/maLopTc={maLopTc}").Result;
                if(httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    List<BangDiemInfoDTO> DsBangDiem = JsonConvert.DeserializeObject<List<BangDiemInfoDTO>>(json);
                    return DsBangDiem;
                }
            }
            return null;
        }


        public static List<BangDiemDTO> GetListBangDiemByMaSinhVien(int maSinhVien)
        {
            using(var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_BangDiem_Url}/maSinhVien={maSinhVien}")
                    .Result;
                if(httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    List<BangDiemDTO> DsBangDiem = JsonConvert.DeserializeObject<List<BangDiemDTO>>(json);
                    return DsBangDiem;
                }
            }
            return null;
        }

        public static HttpStatusCode PostBangDiem(BangDiemDTO bangDiem)
        {
            using(var httpClient = new HttpClient())
            {
                string jsonBangDiem = JsonConvert.SerializeObject(bangDiem);
                HttpResponseMessage response = httpClient.PostAsync(
                    $"{Api_BangDiem_Url}",
                    new StringContent(jsonBangDiem, System.Text.Encoding.UTF8, "application/json"))
                    .Result;
                return response.StatusCode;
            }
        }

        public static HttpStatusCode PutBangDiem(BangDiemDTO bangDiem)
        {
            using(var httpClient = new HttpClient())
            {
                string jsonBangDiem = JsonConvert.SerializeObject(bangDiem);
                HttpResponseMessage response = httpClient.PutAsync(
                    $"{Api_BangDiem_Url}/{bangDiem.MaBangDiem}",
                    new StringContent(jsonBangDiem, System.Text.Encoding.UTF8, "application/json"))
                    .Result;
                return response.StatusCode;
            }
        }
    }
}
