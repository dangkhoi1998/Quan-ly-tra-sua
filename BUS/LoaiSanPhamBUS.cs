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
    public class LoaiSanPhamBUS
    {
        LoaiSanPhamDAL loaisp_dal = new LoaiSanPhamDAL();
        public DataTable listLoaiSp()
        {
            return loaisp_dal.listLoaiSp();
        }
        public DataTable listLoaiSp_SelectMa(LoaiSanPham lsp)
        {
            return loaisp_dal.listLoaiSp_MaLoaiSp(lsp);
        }
        public DataTable LoaiSpInsert(LoaiSanPham lsp)
        {
            return loaisp_dal.LoaiSpInsert(lsp);
        }

        public DataTable LoaiSpDelete(LoaiSanPham lsp)
        {
            return loaisp_dal.LoaiSpDelete(lsp);
        }
    }
}
