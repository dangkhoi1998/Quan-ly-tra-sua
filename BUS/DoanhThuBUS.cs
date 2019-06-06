using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;
using System.Data.SqlClient;

namespace BUS
{
    public class DoanhThuBUS
    {
        DoanhThuDAL doanhthu_dal = new DoanhThuDAL();
        HoaDonDAL hoadon_dal = new HoaDonDAL();
        public bool DoanhthuInsert(TaiKhoan taikhoan)
        {
            SqlDataAdapter sda = hoadon_dal.KhoasoIn(taikhoan);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DoanhThuDTO doanhthu = new DoanhThuDTO();
            doanhthu.TenDangNhap = taikhoan.TenDn;
            doanhthu.TongTienBan = dt.Rows[0][1].ToString();
            doanhthu.TongGiamGia = dt.Rows[0][2].ToString();
            doanhthu.TongVanChuyen = dt.Rows[0][3].ToString();
            doanhthu.TongHoaDon = dt.Rows[0][4].ToString();
            doanhthu.TongDoanhThu = dt.Rows[0][5].ToString();
            doanhthu.ThoiGianBd = dt.Rows[0][6].ToString();
            doanhthu.ThoiGianKt = dt.Rows[0][7].ToString();
            return doanhthu_dal.DoanhthuInsert(doanhthu);
        }

        public DataSet ThongKe_DtThangTrongNam(DoanhThuDTO doanhthu)
        {
            return doanhthu_dal.ThongKe_DtThangTrongNam(doanhthu);
        }

        public DataSet ThongKe_DtCaTrongNgay(DoanhThuDTO doanhthu)
        {
            return doanhthu_dal.ThongKe_DtCaTrongNgay(doanhthu);
        }

        public DataSet ThongKe_DtNgayTrongThang(DoanhThuDTO doanhthu)
        {
            return doanhthu_dal.ThongKe_DtNgayTrongThang(doanhthu);
        }
        public bool DoanhThu_KtChuaChot(DoanhThuDTO doanhthu)
        {
            return doanhthu_dal.DoanhThu_KtChuaChot(doanhthu);
        }
    }
}
