using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {
        private string maCtHoaDon;
        public string MaCtHoaDon
        {
            get { return maCtHoaDon; }
            set { maCtHoaDon = value; }
        }

        private string maHoaDon;
        public string MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }

        private string maSanPham;
        public string MaSanPham
        {
            get { return maSanPham; }
            set { maSanPham = value; }
        }

        private string donGia;


        private string soLuong;
        public string SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public string DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }
    }
}
