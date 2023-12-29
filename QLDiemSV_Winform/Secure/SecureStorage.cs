using CredentialManagement;
using QLDiemSV_Winform.Controller;
using QLDiemSV_Winform.Validation;
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace QLDiemSV_Winform.Secure
{
    public class SecureStorage
    {
        private static EnumCode.Decentralization quyen = EnumCode.Decentralization.None;

        public static HttpStatusCode ChangePassword(string matKhauMoi)
        {
            using (var credential = new Credential { Target = "MyAppCredential" })
            {
                HttpStatusCode httpStatusCode = HttpStatusCode.Gone;
                if (credential.Load())
                {
                    httpStatusCode = GiangVienController.PutMatKhau(
                        new DTO.TaiKhoanDTO(credential.Username, matKhauMoi));
                    bool isChangeSuccessful = StatusCodeChecker.GetResponseClass(httpStatusCode) ==
                        EnumCode.HTTPResponseStatusClass.SuccessfulResponses;
                    if (isChangeSuccessful)
                    {
                        credential.Password = matKhauMoi;
                        return httpStatusCode;
                    }
                }
                return httpStatusCode;
            }
        }

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

        public static string GetTenDangNhap()
        {
            using (var credential = new Credential { Target = "MyAppCredential" })
            {
                if (credential.Load())
                    return credential.Username;
                return null;
            }
        }

        public static void SaveCredentials(string tenDangNhap, string matKhau)
        {
            using (var credential = new Credential())
            {
                credential.Target = "MyAppCredential";
                credential.Username = tenDangNhap;
                credential.Password = matKhau;
                int maQuyen = GiangVienController.GetGiangVien(Convert.ToInt32(tenDangNhap)).MaQuyen;
                quyen = TeacherDecentralization.GetQuyenGiangVien(maQuyen);
                credential.Save();
            }
        }

        public static EnumCode.Decentralization GetQuyen()
        {
            return quyen;
        }
    }
}
