using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace DAL
{
    public class CtHuyNguyenLieuDAL : Connect
    {
        public bool CtHuyNl_Insert(CtHuyNguyenLieuDTO cthuynl)
        {
            //try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("CTHUYNL_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TENNGUYENLIEU", cthuynl.MaNl));
                cmd.Parameters.Add(new SqlParameter("@SOLUONG", Convert.ToDouble(cthuynl.SoLuong)));
                /////////////////////////////////
                DateTime hsd = DateTime.ParseExact(cthuynl.HSd, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                /////////////////////////////////
                cmd.Parameters.Add(new SqlParameter("@HANSUDUNG", Convert.ToDateTime(hsd)));
                cmd.Parameters.Add(new SqlParameter("@DVT", cthuynl.DVt));
                cmd.Parameters.Add(new SqlParameter("@LYDOHUY", cthuynl.LyDoHuy));
                cmd.ExecuteNonQuery();
                closeConnect();
                return true;
            }
            //catch
            {
                return false;
            }
        }

        public bool CtHuyNl_DeleteNl(CtNguyenLieuDTO ctnl)
        {
            //try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("CTHUYNL_DELETENL", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TENNL", ctnl.MaNl));
                cmd.Parameters.Add(new SqlParameter("@SOLUONG", Convert.ToDouble(ctnl.TonKho)));
                /////////////////////////////////
                DateTime hsd = DateTime.ParseExact(ctnl.HSd, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                /////////////////////////////////
                cmd.Parameters.Add(new SqlParameter("@HSD", Convert.ToDateTime(hsd)));
                cmd.Parameters.Add(new SqlParameter("@DVT", ctnl.DVt));
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
