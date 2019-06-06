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
    public class SanPhamDAL : Connect
    {
        public DataTable listSanPham_MaLoaiSp(SanPham sanpham)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("SANPHAM_SELECTMALOAI", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("MALOAISP", sanpham.MaLoaiSp));
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

        public DataTable listSanPham_MaSp(SanPham sanpham)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("SANPHAM_SELECTMA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("MASANPHAM", sanpham.MaSanPham));
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
        public DataTable SanPham_Select()
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("SANPHAM_SELECT", con);
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
        public DataTable SanPham_Insert(SanPham sanpham)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("SANPHAM_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("MASANPHAM", sanpham.MaSanPham));
                cmd.Parameters.Add(new SqlParameter("TENSANPHAM", sanpham.TenSanPham));
                cmd.Parameters.Add(new SqlParameter("GIA", sanpham.Gia));
                cmd.Parameters.Add(new SqlParameter("THONGTIN", sanpham.ThongTin));
                cmd.Parameters.Add(new SqlParameter("MALOAISP", sanpham.MaLoaiSp));
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

        public DataTable SanPham_Update(SanPham sanpham)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("SANPHAM_UPDATE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("MASANPHAM", sanpham.MaSanPham));
                cmd.Parameters.Add(new SqlParameter("GIA", sanpham.Gia));
                cmd.Parameters.Add(new SqlParameter("THONGTIN", sanpham.ThongTin));
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

        public DataTable SanPham_Delete(SanPham sanpham)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("SANPHAM_DELETE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("MASANPHAM", sanpham.MaSanPham));
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
