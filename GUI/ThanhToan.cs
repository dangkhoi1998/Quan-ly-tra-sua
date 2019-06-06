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
using System.Data;

namespace GUI
{
    public partial class ThanhToan : Form
    {
        protected SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLY_QUANLYTRASUA;Integrated Security=True");

        private CtHoaDonBUS cthoadon_bus = new CtHoaDonBUS();
        private HoaDonBUS hoadon_bus = new HoaDonBUS();
        private CongThucBUS congthuc_bus = new CongThucBUS();
        public string tongtien;
        public string ptchietkhau;

        public ThanhToan()
        {
            InitializeComponent();
        }
        public ThanhToan( string _tongtien, string _ptchietkhau) : this()
        {
            tongtien = _tongtien;
            ptchietkhau = _ptchietkhau;
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            Datachonsp();
            txttongtien.Text = tongtien;
            txtptchietkhau.Text = ptchietkhau;
        }

        private void txttienvanchuyen_TextChanged(object sender, EventArgs e)
        {
            double tongtien = Convert.ToDouble(txttongtien.Text);
            double chietkhau = Convert.ToDouble(txttienchietkhau.Text);
            double vanchuyen = 0;
            if (txttienvanchuyen.Text != "")
            {
                vanchuyen = Convert.ToDouble(txttienvanchuyen.Text);
            }
            else
            {
                txttienvanchuyen.Text = "0";
            }
            double thanhtoan = tongtien + vanchuyen - chietkhau;
            double khachdua = thanhtoan;
            double tienthua = khachdua - thanhtoan;
            txtthanhtoan.Text = thanhtoan.ToString();
            txttienkhachdua.Text = khachdua.ToString();
            txttienthua.Text = tienthua.ToString();
        }

        private void txttienkhachdua_TextChanged(object sender, EventArgs e)
        {
            if (txttienkhachdua.Text != "" && txtthanhtoan.Text != "")
            {
                double khachdua = Convert.ToDouble(txttienkhachdua.Text);
                double thanhtoan = Convert.ToDouble(txtthanhtoan.Text);
                double tienthua = khachdua - thanhtoan;
                txttienthua.Text = tienthua.ToString();
            }
            if(txttienkhachdua.Text == "")
            {
                txttienkhachdua.Text = "0";
            }
        }

        private void txttongtien_TextChanged(object sender, EventArgs e)
        {
            txtthanhtoan.Text = txttongtien.Text;
        }

        private void txtthanhtoan_TextChanged(object sender, EventArgs e)
        {
            txttienkhachdua.Text = txtthanhtoan.Text;
        }

        private void txtptchietkhau_TextChanged(object sender, EventArgs e)
        {
            if (txtptchietkhau.Text != "")
            {
                double phantram = Convert.ToDouble(txtptchietkhau.Text);
                double tongtien = Convert.ToDouble(txttongtien.Text);
                double chietkhau = (tongtien * phantram) / 100;
                txttienchietkhau.Text = chietkhau.ToString();
                double vanchuyen = 0;
                if (txttienvanchuyen.Text != "")
                {
                    vanchuyen = Convert.ToDouble(txttienvanchuyen.Text);
                }
                double thanhtoan = tongtien + vanchuyen - chietkhau;
                double khachdua = thanhtoan;
                double tienthua = khachdua - thanhtoan;
                txtthanhtoan.Text = thanhtoan.ToString();
                txttienkhachdua.Text = khachdua.ToString();
                txttienthua.Text = tienthua.ToString();
            }
            else
            {
                txtptchietkhau.Text = "0";
            }
        }

        private void btninhoadon_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txttienthua.Text) < 0)
            {
                MessageBox.Show("Thông báo", "Tiền khách đưa không đủ để thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (ThanhtoanUpdate() == true)
                {
                    CongThuc_ThucThi();
                    InHoaDon();
                }
                else
                {
                    MessageBox.Show("Thông báo", "Thanh toán thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public bool ThanhtoanUpdate()
        {
            HoaDon hoadon = new HoaDon();
            hoadon.TongTien = txttongtien.Text;
            hoadon.GiamGia = txttienchietkhau.Text;
            hoadon.PhiVanChuyen = txttienvanchuyen.Text;
            hoadon.ThanhToan = txtthanhtoan.Text;
            hoadon.KhachDua = txttienkhachdua.Text;
            hoadon.TienThua = txttienthua.Text;
            return hoadon_bus.ThanhtoanUpdate(hoadon);
        }

        public void CongThuc_ThucThi()
        {
            for(int i =0; i < datachonsp.RowCount -1 ; i++)
            {
                CongThucDTO congthuc = new CongThucDTO();
                congthuc.MaSp = datachonsp.Rows[i].Cells[0].Value.ToString();
                string soluong = datachonsp.Rows[i].Cells[2].Value.ToString();
                congthuc_bus.CongThuc_ThucThi(congthuc, soluong).ToString();
            }
        }

        public void Datachonsp()
        {
            datachonsp.DataSource = cthoadon_bus.Cthoadon_selecthd();
            datachonsp.Columns[0].HeaderText = "Mã sản phẩm";
            datachonsp.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datachonsp.Columns[0].Width = 100;
            datachonsp.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datachonsp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datachonsp.Columns[1].HeaderText = "Tên sản phẩm";
            datachonsp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datachonsp.Columns[1].Width = 180;
            datachonsp.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datachonsp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datachonsp.Columns[2].HeaderText = "Số lượng";
            datachonsp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datachonsp.Columns[2].Width = 82;
            datachonsp.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datachonsp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datachonsp.Columns[3].HeaderText = "Đơn giá";
            datachonsp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            datachonsp.Columns[3].Width = 110;
            datachonsp.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datachonsp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datachonsp.Columns[4].HeaderText = "Thành tiền";
            datachonsp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            datachonsp.Columns[4].Width = 140;
            datachonsp.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datachonsp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        public void InHoaDon()
        {
            HoaDonIn hdi = new HoaDonIn();
            DataSet ds = new DataSet();
            hoadon_bus.HoadonIn().Fill(ds);
            HoaDonInn hoadoninn = new HoaDonInn();
            hoadoninn.SetDataSource(ds.Tables[0]);
            hdi.crvhoadon.ReportSource = hoadoninn;
            this.Hide();
            hdi.ShowDialog();
        }










        

        

        private void nhapso(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void clicktxt(object sender, EventArgs e)
        {
            this.txtptchietkhau.SelectAll();
            this.txttienvanchuyen.SelectAll();
            this.txttienkhachdua.SelectAll();
        }

        private void txttienchietkhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
