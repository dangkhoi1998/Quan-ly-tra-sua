using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class SanPhamBUS
    {
        SanPhamDAL sanpham_dal = new SanPhamDAL();
        public DataTable listSanPham_MaLoaiSp(SanPham sanpham)
        {
            return sanpham_dal.listSanPham_MaLoaiSp(sanpham);
        }
        public DataTable SanPham_Insert(SanPham sanpham)
        {
            return sanpham_dal.SanPham_Insert(sanpham);
        }
        public DataTable listSanPham_MaSp(SanPham sanpham)
        {
            return sanpham_dal.listSanPham_MaSp(sanpham);
        }
        public DataTable SanPham_Select()
        {
            return sanpham_dal.SanPham_Select();
        }

        public DataTable SanPham_Update(SanPham sanpham)
        {
            return sanpham_dal.SanPham_Update(sanpham);
        }

        public DataTable SanPham_Delete(SanPham sanpham)
        {
            return sanpham_dal.SanPham_Delete(sanpham);
        }
    }
}
