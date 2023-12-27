using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV_Winform.DTO
{
    internal class BangDiemInfoDTO
    {
        public int MaBangDiem { get; set; }

        public int MaLopTc { get; set; }

        public int MaSv { get; set; }

        public string TenSv { get; set; }

        public double ChuyenCan { get; set; }

        public double BaiTap { get; set; }

        public double KiemTra { get; set; }

        public double ThucHanh { get; set; }

        public double Thi { get; set; }

        public double TongKet { get; set; }
    }
}
