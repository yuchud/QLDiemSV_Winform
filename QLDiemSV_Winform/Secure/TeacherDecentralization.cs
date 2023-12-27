using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;
using QLDiemSV_Winform.Validation;
using QLDiemSV_Winform.DTO;

namespace QLDiemSV_Winform.Secure
{
    internal class TeacherDecentralization
    {
        private static readonly string Api_Quyen = Program.ApiBaseUrl + "/Quyen";
        private static Dictionary<int, EnumCode.Decentralization> pairQuyen = pairQuyen_GetFromApi();

        TeacherDecentralization() {}

        private static Dictionary<int, EnumCode.Decentralization> pairQuyen_GetFromApi()
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync($"{Api_Quyen}").Result;
                if (httpResponse.IsSuccessStatusCode)
                {
                    string json = httpResponse.Content.ReadAsStringAsync().Result;
                    List<QuyenDTO> listQuyen = JsonConvert.DeserializeObject<List<QuyenDTO>>(json);
                    Dictionary<int, EnumCode.Decentralization> keyValuePairs = new Dictionary<int, EnumCode.Decentralization>();
                    foreach (QuyenDTO quyen in listQuyen)
                    {
                        int key = quyen.MaQuyen;
                        string value = quyen.TenQuyen;
                        if(value == "GiangVien")
                        {
                            keyValuePairs.Add(key, EnumCode.Decentralization.GiangVien);
                        }
                        else
                        {
                            keyValuePairs.Add(key, EnumCode.Decentralization.NhanVien);
                        }
                        
                    }
                    return keyValuePairs;
                }
            }
            return null;
        }

        public static EnumCode.Decentralization GetQuyenGiangVien(int maQuyen)
        {
            return pairQuyen[maQuyen];
        }

        public static int GetMaQuyenGiangVien(EnumCode.Decentralization tenQuyen)
        {
            foreach (var kvp in pairQuyen)
            {
                if (kvp.Value == tenQuyen)
                {
                    return kvp.Key;
                }
            }
            return 0;
        }
    }
}
