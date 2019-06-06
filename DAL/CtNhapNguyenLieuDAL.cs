using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Globalization;

namespace DAL
{
    public class CtNhapNguyenLieuDAL : Connect
    {
        public bool CtNhapNl_Insert(CtNhapNguyenLieuDTO ctnhapnl)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("CTNHAPNL_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("MANGUYENLIEU", ctnhapnl.MaNl));
                cmd.Parameters.Add(new SqlParameter("@SOLUONG", Convert.ToDouble(ctnhapnl.SoLuong)));
                /////////////////////////////////
                DateTime hsd = DateTime.ParseExact(ctnhapnl.HSd, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                /////////////////////////////////
                cmd.Parameters.Add(new SqlParameter("@HANSUDUNG", Convert.ToDateTime(hsd)));
                cmd.Parameters.Add(new SqlParameter("@DVT", ctnhapnl.DonViTinh));
                cmd.Parameters.Add(new SqlParameter("@DONGIA", Convert.ToInt32(ctnhapnl.DonGia)));
                cmd.ExecuteNonQuery();
                closeConnect();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable CtNhapNl_InHd()
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("CTNHAPNL_INHD", con);
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

        public bool CtNhapNl_InsertNl(CtNguyenLieuDTO ctnl)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("CTNHAPNL_INSERTNL", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MANL", ctnl.MaNl));
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
            catch
            {
                return false;
            }
        }
    }
}
