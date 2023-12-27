using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV_Winform.DTO
{
    internal class TaiKhoanDTO
    {
        private int userId;
        private string matKhau;
        public TaiKhoanDTO() { }

        public TaiKhoanDTO(string userID, string matKhau)
        {
            this.userId = Convert.ToInt32(userID);
            this.matKhau = matKhau;
        }

        public int UserId { get => userId; set => userId = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
