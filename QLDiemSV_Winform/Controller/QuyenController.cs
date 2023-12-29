using Newtonsoft.Json;
using QLDiemSV_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV_Winform.ApiController
{

    internal class QuyenController
    {
        private static readonly string Api_Quyen_Url = Program.ApiBaseUrl + "/Quyen";
        public QuyenController() { }

        public static QuyenDTO GetQuyen(int maQuyen)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_Quyen_Url}/{maQuyen}").Result;
                if (httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    QuyenDTO Quyen = JsonConvert.DeserializeObject<QuyenDTO>(json);

                    return Quyen;
                }
            }
            return null;
        }

        public static List<QuyenDTO> GetListQuyen()
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_Quyen_Url}").Result;
                if (httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    List<QuyenDTO> DsQuyen = JsonConvert.DeserializeObject<List<QuyenDTO>>(json);
                    return DsQuyen;
                }
            }
            return null;
        }
    }

    
}
