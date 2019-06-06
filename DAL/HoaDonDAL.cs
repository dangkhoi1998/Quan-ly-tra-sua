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
    public class HoaDonDAL :Connect
    {
        public bool Thanhtoan(HoaDon hoadon)
        {
            //try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("HOADON_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TENDANGNHAP", hoadon.TenDangNhap));
                cmd.Parameters.Add(new SqlParameter("@MAKHACHHANG", hoadon.MaKhachHang == "" ? "null" : hoadon.MaKhachHang));
                cmd.ExecuteNonQuery();
                closeConnect(); 
                return true;
            }
            //catch
            {
                return false;
            }
        }

        public bool ThanhtoanUpdate(HoaDon hoadon)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("HOADON_UPDATE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("TONGTIEN", Convert.ToDouble(hoadon.TongTien)));
                cmd.Parameters.Add(new SqlParameter("GIAMGIA", Convert.ToDouble(hoadon.GiamGia)));
                cmd.Parameters.Add(new SqlParameter("PHIVANCHUYEN", Convert.ToDouble(hoadon.PhiVanChuyen)));
                cmd.Parameters.Add(new SqlParameter("THANHTOAN", Convert.ToDouble(hoadon.ThanhToan)));
                cmd.Parameters.Add(new SqlParameter("KHACHDUA", Convert.ToDouble(hoadon.KhachDua)));
                cmd.Parameters.Add(new SqlParameter("TIENTHUA", Convert.ToDouble(hoadon.TienThua)));
                cmd.ExecuteNonQuery();
                closeConnect();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public SqlDataAdapter HoaDonIn()
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("HOADON_SELECTIN", con);
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

        public SqlDataAdapter KhoasoIn(TaiKhoan taikhoan)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("HOADON_KHOASO", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("TENDANGNHAP", taikhoan.TenDn));
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                closeConnect();
                return sda;
            }
            catch
            {
                return null;
            }
        }

        public DataTable KtKhoaSoIn(TaiKhoan taikhoan)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("HOADON_KTKHOASO", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("TENDANGNHAP", taikhoan.TenDn));
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
