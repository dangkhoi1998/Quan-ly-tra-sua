using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class CtNguyenLieuDAL : Connect
    {
        public DataTable CtNguyenLieu_Dvt()
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("CTNGUYENLIEU_DVT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                closeConnect();
                return dt;
            }
            catch
            {
                return null;
            }
        }
    }
}
