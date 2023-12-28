using System;
using System.Linq;

namespace QLDiemSV_Winform.DTO
{
    internal class TaiKhoanDTO
    {
        public TaiKhoanDTO()
        {
        }

        public TaiKhoanDTO(string userID, string matKhau)
        {
            this.UserId = Convert.ToInt32(userID);
            this.MatKhau = matKhau;
        }

        public int UserId { get; set; }

        public string MatKhau { get; set; }
    }
}
