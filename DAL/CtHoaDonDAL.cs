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
    public class CtHoaDonDAL : Connect
    {
        public bool CthoadonInsert(ChiTietHoaDon chitiethoadon)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("CTHOADON_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("MASANPHAM", chitiethoadon.MaSanPham));
                cmd.Parameters.Add(new SqlParameter("DONGIA", Convert.ToDouble(chitiethoadon.DonGia)));
                cmd.Parameters.Add(new SqlParameter("SOLUONG", chitiethoadon.SoLuong));
                cmd.ExecuteNonQuery();
                closeConnect();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CthoadonDelete()
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("CTHOADON_DELETE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                closeConnect();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable Cthoadon_selecthd()
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("CTHOADON_SELECTHD", con);
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

        public SqlDataAdapter CthoadonIn()
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("CTHOADON_SELECTHD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                closeConnect();
                return sda;
            }
            catch
            {
                return null;
            }
        }
    }
}
