using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class TKDoanhThu : Form
    {
        private DoanhThuBUS doanhthu_bus = new DoanhThuBUS();
        public TKDoanhThu()
        {
            InitializeComponent();
        }
        private string theloai = null;
        public TKDoanhThu(string _theloai) : this()
        {
            theloai = _theloai;
        }
        public void TkDtThangTrongNam()
        {
            DoanhThuDTO doanhthu = new DoanhThuDTO();
            doanhthu.ThoiGianKt = dtpthoigian.Value.ToString();
            DataSet ds = doanhthu_bus.ThongKe_DtThangTrongNam(doanhthu);
            TKDtThangTrongNam tkdt = new TKDtThangTrongNam();
            TKDtThangTrongNamIn tkdtin = new TKDtThangTrongNamIn();
            tkdtin.SetDataSource(ds.Tables[0]);
            tkdt.crvTKDtThangTrongNam.ReportSource = tkdtin;
            tkdt.ShowDialog();
        }
        public void TkDtCaTrongNgay()
        {
            DoanhThuDTO doanhthu = new DoanhThuDTO();
            doanhthu.ThoiGianKt = dtpthoigian.Value.ToString();
            DataSet ds = doanhthu_bus.ThongKe_DtCaTrongNgay(doanhthu);
            TKDtCaTrongNgay tkdt = new TKDtCaTrongNgay();
            TKDtCaTrongNgayIn tkdtin = new TKDtCaTrongNgayIn();
            tkdtin.SetDataSource(ds.Tables[0]);
            tkdt.crvdoanhthucatrongngay.ReportSource = tkdtin;
            tkdt.ShowDialog();
        }

        public void TkDtNgayTrongThang()
        {
            DoanhThuDTO doanhthu = new DoanhThuDTO();
            doanhthu.ThoiGianKt = dtpthoigian.Value.ToString();
            DataSet ds = doanhthu_bus.ThongKe_DtCaTrongNgay(doanhthu);
            TKDtNgayTrongThang tkdt = new TKDtNgayTrongThang();
            TKDtNgayTrongThangIn tkdtin = new TKDtNgayTrongThangIn();
            tkdtin.SetDataSource(ds.Tables[0]);
            tkdt.crvdoanhthungaytronthang.ReportSource = tkdtin;
            tkdt.ShowDialog();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
           if(theloai == "doanhthutungthangtrongnam")
            {
                TkDtThangTrongNam();
            }
           if(theloai == "doanhthutungcatrongngay")
            {
                TkDtCaTrongNgay();
            }
           if(theloai == "doanhthutungngaytrongthang")
            {
                TkDtNgayTrongThang();
            }
        }

        private void TKDoanhThu_Load(object sender, EventArgs e)
        {
            if (theloai == "doanhthutungthangtrongnam")
            {
                lbthongtin.Text = "Xin lựa chọn năm";
            }
            if (theloai == "doanhthutungcatrongngay")
            {
                lbthongtin.Text = "Xin lựa chọn ngày";
            }
            if (theloai == "doanhthutungngaytrongthang")
            {
                lbthongtin.Text = "Xin lựa chọn tháng";
            }
        }
    }
}
