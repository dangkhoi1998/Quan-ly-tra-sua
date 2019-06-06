using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;
using System.Data.SqlClient;

namespace BUS
{
    public class CtHoaDonBUS
    {
        CtHoaDonDAL cthoadon_dal = new CtHoaDonDAL();
        public bool CthoadonDelete()
        {
            return cthoadon_dal.CthoadonDelete();
        }
        public bool CthoadonInsert(ChiTietHoaDon chitiethoadon)
        {
            return cthoadon_dal.CthoadonInsert(chitiethoadon);
        }

        public DataTable Cthoadon_selecthd()
        {
            return cthoadon_dal.Cthoadon_selecthd();
        }
        public SqlDataAdapter CthoadonIn()
        {
            return cthoadon_dal.CthoadonIn();
        }
    }
}
