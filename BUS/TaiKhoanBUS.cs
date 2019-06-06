using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAL taikhoan_dal = new TaiKhoanDAL();
        public DataTable Dangnhap(TaiKhoan taikhoan)
        {
            return taikhoan_dal.Dangnhap(taikhoan);
        }
        public bool Doimatkhau(TaiKhoan taikhoan)
        {
            return taikhoan_dal.Doimatkhau(taikhoan);
        }
        public DataTable TaiKhoan_SelectAll()
        {
            return taikhoan_dal.TaiKhoan_SelectAll();
        }
        public DataTable TaiKhoan_SelectAllTen(TaiKhoan taikhoan)
        {
            return taikhoan_dal.TaiKhoan_SelectAllTen(taikhoan);
        }
        public DataTable TaiKhoan_Insert(TaiKhoan taikhoan)
        {
            return taikhoan_dal.TaiKhoan_Insert(taikhoan);
        }
        public DataTable TaiKhoan_Delete(TaiKhoan taikhoan)
        {
            return taikhoan_dal.TaiKhoan_Delete(taikhoan);
        }
    }
}
