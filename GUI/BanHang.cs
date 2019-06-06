using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class BanHang : Form
    {
        private LoaiSanPhamBUS loaisp_bus = new LoaiSanPhamBUS();
        private SanPhamBUS sanpham_bus = new SanPhamBUS();
        private HoaDonBUS hoadon_bus = new HoaDonBUS();
        private CtHoaDonBUS cthoadon_bus = new CtHoaDonBUS();
        private KhachHangBUS khachhang_bus = new KhachHangBUS();
        private CongThucBUS congthuc_bus = new CongThucBUS();

        public string Tendn;
        public string tenchutk;
        public string Makh;
        public string Tenkh;
        public string Ptchietkhau;
        public string Quyen;
        public DataTable DataChonSp;
        public BanHang()
        {
            InitializeComponent();
            listLoaiSp();
            listSanPham_MaLoaiSp();
            listSanPham_MaSp();
            Datachonsp();
        }
        public BanHang(string _tendn,string _tenchutk ,string _makh, string _tenkn, string _ptchietkhau,string _quyen) :this()
        {
            Tendn = _tendn;
            tenchutk = _tenchutk;
            Makh = _makh;
            Tenkh = _tenkn;
            Ptchietkhau = _ptchietkhau;
            Quyen = _quyen;
        }

        public void listLoaiSp()
        {
            cbloaisp.DataSource = loaisp_bus.listLoaiSp();
            cbloaisp.DisplayMember = "TENLOAISP";
            cbloaisp.ValueMember = "MALOAISP";
        }

        public void listSanPham_MaLoaiSp()
        {
            SanPham sanpham = new SanPham();
            string maloaisp = Convert.ToString(cbloaisp.SelectedValue);
            sanpham.MaLoaiSp = maloaisp;
            if (sanpham_bus.listSanPham_MaLoaiSp(sanpham).Rows.Count == 0)
            {
                cbtensp.DataSource = null;
            }
            else
            {
                cbtensp.DataSource = sanpham_bus.listSanPham_MaLoaiSp(sanpham);
                cbtensp.DisplayMember = "TENSANPHAM";
                cbtensp.ValueMember = "MASANPHAM";
            }
         
        }

        public void listSanPham_MaSp()
        {
            SanPham sanpham = new SanPham();
            string masp = cbtensp.SelectedValue == null ? "" : cbtensp.SelectedValue.ToString();
            sanpham.MaSanPham = masp;
            if (sanpham_bus.listSanPham_MaSp(sanpham).Rows.Count == 0)
            {
                cbgia.DataSource = null;
            }
            else
            {
                cbgia.DataSource = sanpham_bus.listSanPham_MaSp(sanpham);
                cbgia.DisplayMember = "GIA";
                cbgia.ValueMember = "THONGTIN";
                gbthongtinsp.Text = cbgia.SelectedValue == null ? "" : cbgia.SelectedValue.ToString();
            }
            
        }

        public void Datachonsp()
        {
            datachonsp.Columns[0].HeaderText = "Mã sản phẩm";
            datachonsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datachonsp.Columns[0].Width = 156;
            datachonsp.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datachonsp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datachonsp.Columns[1].HeaderText = "Tên sản phẩm";
            datachonsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datachonsp.Columns[1].Width = 300;
            datachonsp.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datachonsp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datachonsp.Columns[2].HeaderText = "Số lượng";
            datachonsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datachonsp.Columns[2].Width = 125;
            datachonsp.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datachonsp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datachonsp.Columns[3].HeaderText = "Đơn giá";
            datachonsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            datachonsp.Columns[3].Width = 150;
            datachonsp.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datachonsp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datachonsp.Columns[4].HeaderText = "Thành tiền";
            datachonsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            datachonsp.Columns[4].Width = 170;
            datachonsp.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datachonsp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }
        
        
        public void insertDatachonsp(string masp,string tensp, string soluong, string gia, string thanhtien  )
        {
            String[] row = { masp, tensp, soluong.ToString(), gia.ToString(), thanhtien.ToString() };
            //DataTable row = new DataTable(string masp, string tensp, string soluong, int gia, int thanhtien)
                datachonsp.Rows.Add(row);
            
        }
        public void removeDatachonsp()
        {
            for (int i = 0; i < datachonsp.Rows.Count; i++)
            {
                if (this.datachonsp.Rows[i].Selected == true)
                {
                    //datachonsp.Rows.RemoveAt(this.datachonsp.SelectedRows[0].Index);
                    datachonsp.Rows.RemoveAt(i);
                }
            }
        }
        public void cleadData()
        {
            datachonsp.Rows.Clear();
            txtsoluong.Text = "";
        }
        public void thanhtoan()
        {
            HoaDon hoadon = new HoaDon();
            hoadon.TenDangNhap = (Tendn == null ? "" : Tendn);
            hoadon.MaKhachHang = (Makh == null ? "" : Makh);
            hoadon_bus.Thanhtoan(hoadon);
            cthoadon_bus.CthoadonDelete();
            for (int i = 0; i < datachonsp.Rows.Count - 1; i++)
            {
                ChiTietHoaDon chitiethoadon = new ChiTietHoaDon();
                chitiethoadon.MaSanPham = datachonsp.Rows[i].Cells[0].Value.ToString();
                chitiethoadon.SoLuong = datachonsp.Rows[i].Cells[2].Value.ToString();
                chitiethoadon.DonGia = datachonsp.Rows[i].Cells[3].Value.ToString();
                cthoadon_bus.CthoadonInsert(chitiethoadon);
            }
        }
        public DataTable Congthuc_KtLuong()
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < datachonsp.Rows.Count - 1; i++)
            {
                CongThucDTO congthuc = new CongThucDTO();
                congthuc.MaSp = datachonsp.Rows[i].Cells[0].Value.ToString();
                double soluong = Convert.ToInt32(datachonsp.Rows[i].Cells[2].Value.ToString());
                for(int j=0; j < i; j++)
                {
                    if(datachonsp.Rows[j].Cells[0].Value.ToString() == congthuc.MaSp)
                    {
                        soluong = soluong + Convert.ToDouble(datachonsp.Rows[j].Cells[2].Value.ToString());
                    }
                }
                dt = congthuc_bus.Congthuc_KtLuong(congthuc, soluong.ToString());
            }
            return dt;
        }




        private void BanHang_Load(object sender, EventArgs e)
        {
            thoigianhientai_Tick(sender, e);
            khachhang_bus.KhachhangTanghang();
        }

        private void thoigianhientai_Tick(object sender, EventArgs e)
        {
            lbthoigianchay.Text = DateTime.Now.ToLongTimeString();
            thoigianhientai.Start();
            int ngay = DateTime.Now.Day;
            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;
            lbngayhientai.Text = Convert.ToString(ngay) + " / " + Convert.ToString(thang) + " / " + Convert.ToString(nam);
        }

        private void cbloaisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            listSanPham_MaLoaiSp();
            listSanPham_MaSp();
        }

        private void cbtensp_SelectedIndexChanged(object sender, EventArgs e)
        {
            listSanPham_MaSp();
        }

        private void btnluachon_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtsoluong.Text != "" && cbgia.Text != "" && cbtensp.Text != "" && cbloaisp.Text != "")
                {
                    bool kt = new bool();
                    //for(int i = 0; i < dataktchonsp.Rows.Count - 1; i++)
                    //{
                    //    if(dataktchonsp.Rows[i].Cells[1].Value.ToString() == cbtensp.Text)
                    //    {
                    //        dataktchonsp.Rows[i].Cells[2].Value = Convert.ToInt32(dataktchonsp.Rows[i].Cells[2].Value.ToString()) + Convert.ToInt32(txtsoluong.Text);
                    //        kt = true;
                    //    }
                    //    else
                    //    {
                    //        kt = false;
                    //    }
                    //}
                    insertDatachonsp(cbtensp.SelectedValue.ToString(), cbtensp.Text, txtsoluong.Text, cbgia.Text, (Convert.ToInt32(txtsoluong.Text) * Convert.ToDouble(cbgia.Text)).ToString());
                
                    txttongsoluong_TextChanged(sender, e);
                    txttongtien_TextChanged(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Không thể thêm món vì số tiền quá lớn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void btnbomon_Click(object sender, EventArgs e)
        {
            removeDatachonsp();
            txttongsoluong_TextChanged(sender, e);
            txttongtien_TextChanged(sender, e);
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            cleadData();
            txttongsoluong_TextChanged(sender, e);
            txttongtien_TextChanged(sender, e);
        }
        private void txttongsoluong_TextChanged(object sender, EventArgs e)
        {
            double sumsoluong = 0;
            for (int i = 0; i < datachonsp.RowCount - 1; i++)
            {
                sumsoluong += Convert.ToDouble(datachonsp.Rows[i].Cells[2].Value.ToString());
            }
            txttongsoluong.Text = sumsoluong.ToString();
        }

        private void txttongtien_TextChanged(object sender, EventArgs e)
        {
            double sumtien = 0;
            for (int i = 0; i < datachonsp.RowCount - 1; i++)
            {
                sumtien += Convert.ToDouble(datachonsp.Rows[i].Cells[4].Value.ToString());
            }
            double tongtien = Convert.ToDouble(sumtien.ToString());
            string t = string.Format("{0:0,0}", tongtien);
            txttongtien.Text = t;
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            if(datachonsp.Rows.Count == 1)
            {
                MessageBox.Show( "Chưa có sản phẩm nào được order !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(Congthuc_KtLuong().Rows.Count > 0)
            {
                MessageBox.Show(Congthuc_KtLuong().Rows[0][0].ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                thanhtoan();
                ThanhToan tt = new ThanhToan(txttongtien.Text, Ptchietkhau == null ? "0" : Ptchietkhau);
                tt.ShowDialog();
            }
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            KhachHang khachhang = new KhachHang(Tendn,tenchutk,Quyen);
            this.Hide();
            khachhang.ShowDialog();

        }








        private void nhapso(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void kothaydoi(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }

        private void click_soluong(object sender, EventArgs e)
        {
            txtsoluong.Text = "";
        }

        private void tat(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btnhdmoi_Click(object sender, EventArgs e)
        {
            cleadData();
            Makh = "";
            txttongsoluong_TextChanged(sender, e);
            txttongtien_TextChanged(sender, e);
        }

        private void thaydoidata(object sender, DataGridViewCellEventArgs e)
        {
            txttongsoluong_TextChanged(sender, e);
            txttongtien_TextChanged(sender, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void datachonsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
