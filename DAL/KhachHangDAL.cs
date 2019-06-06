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
    public class KhachHangDAL : Connect
    {
        public DataTable KhachhangSelect()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("KHACHHANG_SELECT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public string KhachhangInsert(KhachHangDTO khachhang)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("KHACHHANG_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("MAKHACHHANG", khachhang.MaKh));
                cmd.Parameters.Add(new SqlParameter("TENKHACHHANG", khachhang.TenKh));
                cmd.Parameters.Add(new SqlParameter("NGAYSINH", Convert.ToDateTime(khachhang.NgaySinh)));
                cmd.Parameters.Add(new SqlParameter("DIACHI", khachhang.DiaChi));
                cmd.Parameters.Add(new SqlParameter("SDT", khachhang.SDt));
                cmd.Parameters.Add(new SqlParameter("GHICHU", khachhang.GhiChu));
                string thongbao = cmd.ExecuteScalar().ToString();
                closeConnect();
                return thongbao;
            }
            catch
            {
                return null;
            }
        }


        public int KhachhangUpdate(KhachHangDTO khachhang)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("KHACHHANG_UPDATE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("MAKHACHHANG", khachhang.MaKh));
                cmd.Parameters.Add(new SqlParameter("TENKHACHHANG", khachhang.TenKh));
                cmd.Parameters.Add(new SqlParameter("NGAYSINH", Convert.ToDateTime(khachhang.NgaySinh)));
                cmd.Parameters.Add(new SqlParameter("DIACHI", khachhang.DiaChi));
                cmd.Parameters.Add(new SqlParameter("SDT", khachhang.SDt));
                cmd.Parameters.Add(new SqlParameter("GHICHU", khachhang.GhiChu));
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                int thongbao = Convert.ToInt32(dt.Rows[0][0].ToString());
                closeConnect();
                return thongbao;
            }
            catch
            {
                return 3;
            }
        }


        public bool KhachhangDelete(KhachHangDTO khachhang)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("KHACHHANG_DELETE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("MAKHACHHANG", khachhang.MaKh));
                cmd.ExecuteNonQuery();
                closeConnect();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable KhachhangSelectSdt(KhachHangDTO khachhang)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("KHACHHANG_SELECTSDT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("SDT", khachhang.SDt));
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

        public DataTable KhachhangChapnhan(KhachHangDTO khachhang)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("KHACHHANG_CHAPNHAN", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("MAKHACHHANG", khachhang.MaKh));
                cmd.Parameters.Add(new SqlParameter("SDT", khachhang.SDt));
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

        public void KhachhangTanghang()
        {
            DataTable dt = KhachhangSelect();
            for(int i = 0; i < dt.Rows.Count - 1; i++)
            {
                string makh = dt.Rows[i][0].ToString();
                openConnect();
                SqlCommand cmd = new SqlCommand("KHACHHANG_TANGHANG", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("MAKH", makh));
                cmd.ExecuteNonQuery();
                closeConnect();
            }
        }

        //public void KhachhangTanghangCc()
        //{
        //    try
        //    {
        //        openConnect();
        //        SqlCommand cmd = new SqlCommand("KHACHHANG_TANGHANGCC", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.ExecuteNonQuery();
        //        closeConnect();
        //    }
        //    catch
        //    {
        //    }
        //}
    }
}
