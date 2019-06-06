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
    public class TaiKhoanDAL : Connect
    {
        public DataTable Dangnhap(TaiKhoan taikhoan)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("TAIKHOAN_DANGNHAP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("TENDANGNHAP", taikhoan.TenDn));
                cmd.Parameters.Add(new SqlParameter("MATKHAU", taikhoan.MatKhau));
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                closeConnect();
                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool Doimatkhau(TaiKhoan taikhoan)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("TAIKHOAN_DOIMK", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("TENDANGNHAP", taikhoan.TenDn));
                cmd.Parameters.Add(new SqlParameter("MATKHAU", taikhoan.MatKhau));
                cmd.ExecuteNonQuery();
                closeConnect();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public DataTable TaiKhoan_SelectAll()
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("TAIKHOAN_SELECTALL", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                closeConnect();
                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public DataTable TaiKhoan_SelectAllTen(TaiKhoan taikhoan)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("TAIKHOAN_SELECTALLTEN", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TENCHUTAIKHOAN", taikhoan.ChuTk));
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                closeConnect();
                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public DataTable TaiKhoan_Insert(TaiKhoan taikhoan)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("TAIKHOAN_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TENDN", taikhoan.TenDn));
                cmd.Parameters.Add(new SqlParameter("@MK", taikhoan.MatKhau));
                cmd.Parameters.Add(new SqlParameter("@TENCHUTK", taikhoan.ChuTk));
                cmd.Parameters.Add(new SqlParameter("@QUYEN", Convert.ToInt32(taikhoan.Quyen)));
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                closeConnect();
                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public DataTable TaiKhoan_Delete(TaiKhoan taikhoan)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("TAIKHOAN_DELETE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TENDN", taikhoan.TenDn));
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                closeConnect();
                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
