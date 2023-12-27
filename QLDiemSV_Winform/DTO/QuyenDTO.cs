using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV_Winform.DTO
{
    internal class QuyenDTO
    {
        private int maQuyen;
        private string tenQuyen;
        public QuyenDTO() { }

        public QuyenDTO(string maQuyen, string tenQuyen)
        {
            this.maQuyen = Convert.ToInt32(maQuyen);
            this.tenQuyen = tenQuyen;
        }

        public int MaQuyen { get => maQuyen; set => maQuyen = value; }
        public string TenQuyen { get => tenQuyen; set => tenQuyen = value; }
    }
}
