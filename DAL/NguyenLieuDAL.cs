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
    public class NguyenLieuDAL : Connect
    {
        public DataTable NguyenLieu_SelectAll()
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("NGUYENLIEU_SELECTALL", con);
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

        public DataTable NguyenLieu_Select()
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("NGUYENLIEU_SELECT", con);
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

        public DataTable NguyenLieu_SelectAllMa(NguyenLieuDTO nguyenlieu)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("NGUYENLIEU_SELECTALLMA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("MANGUYENLIEU", nguyenlieu.MaNl));
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

        public DataTable NguyenLieu_Insert(NguyenLieuDTO nguyenlieu)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("NGUYENLIEU_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("MANGUYENLIEU", nguyenlieu.MaNl));
                cmd.Parameters.Add(new SqlParameter("TENNGUYENLIEU", nguyenlieu.TenNl));
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

        public DataTable NguyenLieu_Delete(NguyenLieuDTO nguyenlieu)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("NGUYENLIEU_Delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("MANGUYENLIEU", nguyenlieu.MaNl));
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
