using Newtonsoft.Json;
using QLDiemSV_Winform.ApiController;
using QLDiemSV_Winform.DTO;
using QLDiemSV_Winform.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace QLDiemSV_Winform.Secure
{
    internal class TeacherDecentralization
    {
        private static readonly string Api_Quyen = Program.ApiBaseUrl + "/Quyen";

        TeacherDecentralization()
        {
        }

        private static Dictionary<int, EnumCode.Decentralization> pairQuyen_GetFromApi()
        {
            try
            {
                List<QuyenDTO> listQuyen = QuyenController.GetListQuyen();
                Dictionary<int, EnumCode.Decentralization> keyValuePairs = new Dictionary<int, EnumCode.Decentralization>(
                        );
                foreach (QuyenDTO quyen in listQuyen)
                {
                    int key = quyen.MaQuyen;
                    string value = quyen.TenQuyen;
                    if (value == "GiangVien")
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
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

        public static EnumCode.Decentralization GetQuyenGiangVien(int maQuyen) => pairQuyen[maQuyen];

        private static Dictionary<int, EnumCode.Decentralization> pairQuyen = pairQuyen_GetFromApi();
    }
}
