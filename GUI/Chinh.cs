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
using System.Data.SqlClient;

namespace GUI
{
    public partial class Chinh : Form
    {
        private HoaDonBUS hoadon_bus = new HoaDonBUS();
        private DoanhThuBUS doanhthu_bus = new DoanhThuBUS();
        public string TenDangNhap;
        public string TenChuTk;
        public string Quyen;
        public Chinh()
        {
            InitializeComponent();
        }
        
        public Chinh(string tendangnhap,string tenchutk, string quyen) :this()
        {
            TenDangNhap = tendangnhap;
            TenChuTk = tenchutk;
            Quyen = quyen;
        }
        private void Chinh_Load(object sender, EventArgs e)
        {
            if(Quyen == "0")
            {
                btnthongke.Visible = false;
            }
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            DoanhThuDTO doanhthu = new DoanhThuDTO();
            doanhthu.TenDangNhap = TenDangNhap;
            if (doanhthu_bus.DoanhThu_KtChuaChot(doanhthu) == true)
            {
                DangNhap dn = new DangNhap();
                this.TenDangNhap = "";
                dn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn chưa chốt ca, không thể thoát", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btndoimatkhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau(TenDangNhap);
            dmk.ShowDialog();

        }

        private void btnbanhang_Click(object sender, EventArgs e)
        {
            BanHang bn = new BanHang(TenDangNhap,TenChuTk,"","","",Quyen);
            bn.ShowDialog();
        }

        private void btnkhoaso_Click(object sender, EventArgs e)
        {
            Khoaso();
        }

        public void Khoaso()
        {
            TaiKhoan taikhoan = new TaiKhoan();
            taikhoan.TenDn = TenDangNhap;
            DataTable dt = hoadon_bus.KtKhoaSoIn(taikhoan);
            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có hóa đơn nào để chốt ca !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlDataAdapter sda = hoadon_bus.KhoasoIn(taikhoan);
                DataTable dtKhoaSo = new DataTable();
                sda.Fill(dtKhoaSo);
                if(dtKhoaSo.Rows.Count > 0)
                {
                    KhoaSo khoaso = new KhoaSo();
                    khoaso.TenDn = TenDangNhap;
                    //SqlDataAdapter sda = hoadon_bus.KhoasoIn(taikhoan);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    KhoaSoIn khoasoin = new KhoaSoIn();
                    khoasoin.SetDataSource(ds.Tables[0]);
                    khoaso.crvkhoaso.ReportSource = khoasoin;
                    khoaso.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bạn chưa thanh toán thêm hóa đơn nào mới ở tài khoản hiện tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }

          
        }

        private void btnquanly_Click(object sender, EventArgs e)
        {
            QuanLy quanly = new QuanLy(TenDangNhap,Quyen);
            quanly.ShowDialog();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
            tk.ShowDialog();
        }

        private void tat(object sender, FormClosingEventArgs e)
        {
            DoanhThuDTO doanhthu = new DoanhThuDTO();
            doanhthu.TenDangNhap = TenDangNhap;
            if (doanhthu_bus.DoanhThu_KtChuaChot(doanhthu) == true)
            {
                DialogResult hoi = MessageBox.Show("Bạn có thật sự muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hoi == DialogResult.Yes)
                {
                    DangNhap dn = new DangNhap();
                    this.Hide();
                    dn.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chốt ca, không thể thoát", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
    }
}
