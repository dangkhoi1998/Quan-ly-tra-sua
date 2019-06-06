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
    public class DoanhThuDAL : Connect
    {
        
        public bool DoanhthuInsert(DoanhThuDTO doanhthu)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("DOANHTHU_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("TENDANGNHAP", doanhthu.TenDangNhap));
                cmd.Parameters.Add(new SqlParameter("TONGTIENBAN", Convert.ToDouble(doanhthu.TongTienBan)));
                cmd.Parameters.Add(new SqlParameter("TONGGIAMGIA", Convert.ToDouble(doanhthu.TongGiamGia)));
                cmd.Parameters.Add(new SqlParameter("TONGVANCHUYEN", Convert.ToDouble(doanhthu.TongVanChuyen)));
                cmd.Parameters.Add(new SqlParameter("TONGHOADON", Convert.ToDouble(doanhthu.TongHoaDon)));
                cmd.Parameters.Add(new SqlParameter("TONGDOANHTHU", Convert.ToDouble(doanhthu.TongDoanhThu)));
                cmd.Parameters.Add(new SqlParameter("THOIGIANBD", Convert.ToDateTime(doanhthu.ThoiGianBd)));
                cmd.Parameters.Add(new SqlParameter("THOIGIANKT", Convert.ToDateTime(doanhthu.ThoiGianKt)));
                cmd.ExecuteNonQuery();
                closeConnect();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataSet ThongKe_DtThangTrongNam(DoanhThuDTO doanhthu)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("THONGKE_DTTHANGTRONGNAM", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@THOIGIAN", Convert.ToDateTime(doanhthu.ThoiGianKt)));
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                closeConnect();
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public DataSet ThongKe_DtCaTrongNgay(DoanhThuDTO doanhthu)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("THONGKE_DTCATRONGNGAY", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@THOIGIAN", Convert.ToDateTime(doanhthu.ThoiGianKt)));
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                closeConnect();
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public DataSet ThongKe_DtNgayTrongThang(DoanhThuDTO doanhthu)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("THONGKE_DTNGAYTRONGTHANG", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@THOIGIAN", Convert.ToDateTime(doanhthu.ThoiGianKt)));
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                closeConnect();
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public bool DoanhThu_KtChuaChot(DoanhThuDTO doanhthu)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("DOANHTHU_KTCHUACHOT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TENDANGNHAP",doanhthu.TenDangNhap ));
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                closeConnect();
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
