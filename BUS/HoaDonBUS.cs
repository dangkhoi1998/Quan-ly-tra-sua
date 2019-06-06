using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class HoaDonBUS
    {
        HoaDonDAL hoadon_dal = new HoaDonDAL();
        public bool Thanhtoan(HoaDon hoadon)
        {
            return hoadon_dal.Thanhtoan(hoadon);
        }
        public bool ThanhtoanUpdate(HoaDon hoadon)
        {
            return hoadon_dal.ThanhtoanUpdate(hoadon);
        }
        public SqlDataAdapter HoadonIn()
        {
            return hoadon_dal.HoaDonIn();
        }
        public SqlDataAdapter KhoasoIn(TaiKhoan taikhoan)
        {
            return hoadon_dal.KhoasoIn(taikhoan);
        }
        public DataTable KtKhoaSoIn(TaiKhoan taikhoan)
        {
            return hoadon_dal.KtKhoaSoIn(taikhoan);
        }
    }
}
