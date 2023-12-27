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
    internal class BangDiemApiController
    {

        private static readonly string Api_BangDiem_Url = Program.ApiBaseUrl + "/BangDiem";
        public BangDiemApiController() { }

        public static BangDiemDTO GetBangDiem(int maBangDiem)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_BangDiem_Url}/{maBangDiem}").Result;
                if (httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    BangDiemDTO BangDiem = JsonConvert.DeserializeObject<BangDiemDTO>(json);

                    return BangDiem;
                }
            }
            return null;
        }


        public static List<BangDiemDTO> GetListBangDiemByMaLopTinChi(int maLopTc)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_BangDiem_Url}/maLopTc={maLopTc}").Result;
                if (httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    List<BangDiemDTO> DsBangDiem = JsonConvert.DeserializeObject<List<BangDiemDTO>>(json);
                    return DsBangDiem;
                }
            }
            return null;
        }


        public static List<BangDiemDTO> GetListBangDiemByMaSinhVien(int maSinhVien)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_BangDiem_Url}/maSinhVien={maSinhVien}").Result;
                if (httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    List<BangDiemDTO> DsBangDiem = JsonConvert.DeserializeObject<List<BangDiemDTO>>(json);
                    return DsBangDiem;
                }
            }
            return null;
        }

        public static HttpStatusCode PostBangDiem(BangDiemDTO sinhVien)
        {
            using (var httpClient = new HttpClient())
            {
                string jsonBangDiem = JsonConvert.SerializeObject(sinhVien);
                HttpResponseMessage response = httpClient.PostAsync($"{Api_BangDiem_Url}", new StringContent(jsonBangDiem, System.Text.Encoding.UTF8, "application/json")).Result;
                return response.StatusCode;
            }
        }

        public static HttpStatusCode PutBangDiem(BangDiemDTO sinhVien)
        {
            using (var httpClient = new HttpClient())
            {
                string jsonBangDiem = JsonConvert.SerializeObject(sinhVien);
                HttpResponseMessage response = httpClient.PutAsync($"{Api_BangDiem_Url}/{sinhVien.MaSv}", new StringContent(jsonBangDiem, System.Text.Encoding.UTF8, "application/json")).Result;
                return response.StatusCode;
            }
        }

        public static EnumCode.ApiDeleteResult DeleteBangDiem(int maBangDiem)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    HttpResponseMessage httpResponse = httpClient.DeleteAsync($"{Api_BangDiem_Url}/{maBangDiem}").Result;
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
