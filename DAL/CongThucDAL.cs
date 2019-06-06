using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class CongThucDAL : Connect
    {
        public DataTable CongThuc_SelectAll()
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("CONGTHUC_SELECTALL", con);
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

        public DataTable CongThuc_SelectAllMaSp(CongThucDTO congthuc)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("CONGTHUC_SELECTALLMASP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MASANPHAM", congthuc.MaSp));
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

        public DataTable CongThuc_TenSpKoCt()
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("CONGTHUC_TENSPKOCT", con);
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

        public DataTable CongThuc_Insert(CongThucDTO congthuc)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("CONGTHUC_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TENSANPHAM", congthuc.MaSp));
                cmd.Parameters.Add(new SqlParameter("@TENNGUYENLIEU", congthuc.MaNl));
                cmd.Parameters.Add(new SqlParameter("@TIEUHAO", Convert.ToDouble(congthuc.TieuHao)));
                cmd.Parameters.Add(new SqlParameter("@DONVITINH", congthuc.DVt));
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

        public DataTable CongThuc_Update(CongThucDTO congthuc)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("CONGTHUC_UPDATE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TENSANPHAM", congthuc.MaSp));
                cmd.Parameters.Add(new SqlParameter("@TENNGUYENLIEU", congthuc.MaNl));
                cmd.Parameters.Add(new SqlParameter("@TIEUHAO", Convert.ToDouble(congthuc.TieuHao)));
                cmd.Parameters.Add(new SqlParameter("@DONVITINH", congthuc.DVt));
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

        public DataTable CongThuc_Delete(CongThucDTO congthuc)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("CONGTHUC_DELETE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TENSANPHAM", congthuc.MaSp));
                cmd.Parameters.Add(new SqlParameter("@TENNGUYENLIEU", congthuc.MaNl));
                cmd.Parameters.Add(new SqlParameter("@TIEUHAO", Convert.ToDouble(congthuc.TieuHao)));
                cmd.Parameters.Add(new SqlParameter("@DONVITINH", congthuc.DVt));
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

        public DataTable CongThuc_KtLuongSp(CongThucDTO congthuc)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("CONGTHUC_KTLUONGSP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MASANPHAM", congthuc.MaSp));
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

        public DataTable CongThuc_KtLuongNl(CongThucDTO congthuc,string soluong)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("CONGTHUC_KTLUONGNL", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SOLUONG", Convert.ToInt32(soluong)));
                cmd.Parameters.Add(new SqlParameter("@MASANPHAM", congthuc.MaSp));
                cmd.Parameters.Add(new SqlParameter("@MANGUYENLIEU", congthuc.MaNl));
                cmd.Parameters.Add(new SqlParameter("@TIEUHAO", Convert.ToDouble(congthuc.TieuHao)));
                cmd.Parameters.Add(new SqlParameter("@DONVITINH", congthuc.DVt));
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

        public bool CongThuc_ThucThi(CongThucDTO congthuc,string soluong)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("CONGTHUC_THUCTHI", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SOLUONG", Convert.ToInt32(soluong)));
                cmd.Parameters.Add(new SqlParameter("@MANGUYENLIEU", congthuc.MaNl));
                cmd.Parameters.Add(new SqlParameter("@TIEUHAO", Convert.ToDouble(congthuc.TieuHao)));
                cmd.Parameters.Add(new SqlParameter("@DONVITINH", congthuc.DVt));
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
