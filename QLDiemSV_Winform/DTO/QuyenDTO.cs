using System;
using System.Linq;

namespace QLDiemSV_Winform.DTO
{
    internal class QuyenDTO
    {
        public QuyenDTO()
        {
        }

        public QuyenDTO(string maQuyen, string tenQuyen)
        {
            this.MaQuyen = Convert.ToInt32(maQuyen);
            this.TenQuyen = tenQuyen;
        }

        public int MaQuyen { get; set; }

        public string TenQuyen { get; set; }
    }
}
