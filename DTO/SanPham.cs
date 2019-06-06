using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        private string maSanPham;
        public string MaSanPham
        {
            get { return maSanPham; }
            set { maSanPham = value; }
        }
        private string tenSanPham;
        public string TenSanPham
        {
            get { return tenSanPham; }
            set { tenSanPham = value; }
        }
        private string gia;
        public string Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        private string thongTin;
        public string ThongTin
        {
            get { return thongTin; }
            set { thongTin = value; }
        }
        private string maLoaiSp;
        public string MaLoaiSp
        {
            get { return maLoaiSp; }
            set { maLoaiSp = value; }
        }
    }
}
