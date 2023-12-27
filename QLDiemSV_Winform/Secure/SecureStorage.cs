﻿using CredentialManagement;
using QLDiemSV_Winform.Controller;
using QLDiemSV_Winform.Validation;
using System;
using System.Linq;

namespace QLDiemSV_Winform.Secure
{
    public class SecureStorage
    {
        private static EnumCode.Decentralization quyen = EnumCode.Decentralization.None;

        public static EnumCode.Decentralization Quyen { get => quyen; }

        public static void ClearCredentials()
        {
            using (var credential = new Credential { Target = "MyAppCredential" })
            {
                credential.Delete();
                quyen = EnumCode.Decentralization.None;
            }
        }

        public static (string tenDangNhap, string matKhau, EnumCode.Decentralization) GetCredentials()
        {
            using (var credential = new Credential { Target = "MyAppCredential" })
            {
                if (credential.Load())
                    return (credential.Username, credential.Password, quyen);
                return (null, null, EnumCode.Decentralization.None);
            }
        }

        public static void SaveCredentials(string tenDangNhap, string matKhau)
        {
            using (var credential = new Credential())
            {
                credential.Target = "MyAppCredential";
                credential.Username = tenDangNhap;
                credential.Password = matKhau;
                int maQuyen = GiangVienApiController.GetGiangVien(Convert.ToInt32(tenDangNhap)).MaQuyen;
                quyen = TeacherDecentralization.GetQuyenGiangVien(maQuyen);
                credential.Save();
            }
        }

        public static string GetTenDangNhap()
        {
            using (var credential = new Credential { Target = "MyAppCredential" })
            {
                if (credential.Load())
                    return credential.Username;
                return null;
            }
        }
    }
}