using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class HuyNguyenLieuDAL : Connect
    {
        public bool HuyNguyenLieu_Insert(HuyNguyenLieuDTO huynl)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("HUYNL_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TENDN", huynl.TenDn));
                cmd.ExecuteNonQuery();
                closeConnect();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
