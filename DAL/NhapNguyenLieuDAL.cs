using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class NhapNguyenLieuDAL : Connect
    {
        public bool NhapNguyenLieu_Insert(NhapNguyenLieuDTO nhapnl)
        {
           //try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("NHAPNGUYENLIEU_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MANCC", nhapnl.MaNcc));
                cmd.Parameters.Add(new SqlParameter("@TENDN", nhapnl.TenDn));
                cmd.Parameters.Add(new SqlParameter("@NGAYNHAP", Convert.ToDateTime(nhapnl.NgayNhap)));
                cmd.Parameters.Add(new SqlParameter("@TONGTIEN",Convert.ToDouble(nhapnl.TongTien)));
                cmd.ExecuteNonQuery();
                closeConnect();
                return true;
            }
            //catch
            {
                return false;
            }
        }
    }
}
