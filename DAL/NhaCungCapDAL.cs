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
    public class NhaCungCapDAL : Connect
    {

        public DataTable NhaCc_Select()
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("NHACC_SELECT", con);
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

        public DataTable NhaCc_SelectMa(NhaCungCapDTO nhacc)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("NHACC_SELECTMA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("MANCC", nhacc.MaNhaCc));
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

        public DataTable NhaCc_Insert(NhaCungCapDTO nhacc)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("NHACC_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MANCC", nhacc.MaNhaCc));
                cmd.Parameters.Add(new SqlParameter("@TENNCC", nhacc.TenNhaCc));
                cmd.Parameters.Add(new SqlParameter("@SDT", nhacc.SDt));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", nhacc.DiaChi));
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

        public DataTable NhaCc_Update(NhaCungCapDTO nhacc)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("NHACC_UPDATE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MANCC", nhacc.MaNhaCc));
                cmd.Parameters.Add(new SqlParameter("@TENNCC", nhacc.TenNhaCc));
                cmd.Parameters.Add(new SqlParameter("@SDT", nhacc.SDt));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", nhacc.DiaChi));
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

        public DataTable NhaCc_Delete(NhaCungCapDTO nhacc)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("NHACC_DELETE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MANCC", nhacc.MaNhaCc));
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
