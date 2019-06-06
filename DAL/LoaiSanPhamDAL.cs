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
    public class LoaiSanPhamDAL : Connect
    {
        public DataTable listLoaiSp()
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("LOAISANPHAM_SELECT", con);
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
        public DataTable LoaiSpInsert(LoaiSanPham lsp)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("LOAISANPHAM_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("MALOAISP", lsp.MaLoaiSp));
                cmd.Parameters.Add(new SqlParameter("TENLOAISP", lsp.TenLoaiSp));
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
        public DataTable LoaiSpDelete(LoaiSanPham lsp)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("LOAISANPHAM_DELETE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("MALOAISP", lsp.MaLoaiSp));
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

        public DataTable listLoaiSp_MaLoaiSp(LoaiSanPham lsp)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("LOAISANPHAM_SELECTMA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("MALOAISP", lsp.MaLoaiSp));
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
