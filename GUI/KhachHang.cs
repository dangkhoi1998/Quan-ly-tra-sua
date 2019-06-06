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
    public partial class KhachHang : Form
    {
        private KhachHangBUS khachhang_bus = new KhachHangBUS();
        public string tendn;
        public string tenchutk;
        public string makh;
        public string tenkh;
        public string ptchietkhau;
        public string quyen;
        public KhachHang()
        {
            InitializeComponent();
        }
        public KhachHang(string _tendn, string _tenchutk, string _quyen) : this()
        {
            tendn = _tendn;
            tenchutk = _tenchutk;
            quyen = _quyen;
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            if(quyen == "0")
            {
                btnxoasp.Visible = false;
            }
            KhachhangSelect();
            datakhachhang.Columns[0].HeaderText = "Mã KH";
            datakhachhang.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datakhachhang.Columns[0].Width = 120;
            datakhachhang.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datakhachhang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datakhachhang.Columns[1].HeaderText = "Họ tên KH";
            datakhachhang.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datakhachhang.Columns[1].Width = 220;
            datakhachhang.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datakhachhang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datakhachhang.Columns[2].HeaderText = "Ngày sinh";
            datakhachhang.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            datakhachhang.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datakhachhang.Columns[2].Width = 130;
            datakhachhang.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datakhachhang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datakhachhang.Columns[3].HeaderText = "Địa chỉ";
            datakhachhang.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datakhachhang.Columns[3].Width = 155;
            datakhachhang.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datakhachhang.Columns[4].HeaderText = "SĐT";
            datakhachhang.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            datakhachhang.Columns[4].Width = 140;
            datakhachhang.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datakhachhang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datakhachhang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datakhachhang.Columns[5].HeaderText = "Loại KH";
            datakhachhang.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datakhachhang.Columns[5].Width = 133;
            datakhachhang.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datakhachhang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datakhachhang.Columns[6].HeaderText = "Ngày lập";
            datakhachhang.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            datakhachhang.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datakhachhang.Columns[6].Width = 130;
            datakhachhang.Columns[6].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datakhachhang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datakhachhang.Columns[7].HeaderText = "Ghi chú";
            datakhachhang.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datakhachhang.Columns[7].Width = 140;
            datakhachhang.Columns[7].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //datakhachhang.Columns[8].HeaderText = "Lượng thanh toán trong tháng";
            //datakhachhang.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //datakhachhang.Columns[8].Width = 140;
            //datakhachhang.Columns[8].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datakhachhang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnthemkh_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Thiếu thông tin mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtsdt.Text == "")
            {
                MessageBox.Show("Thiếu thông tin số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                KhachhangInsert();
                datakhachhang.DataSource = khachhang_bus.KhachhangSelect();
            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            clear();
            datakhachhang.DataSource = khachhang_bus.KhachhangSelect();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if (txtsdt.Text == "")
            {
                MessageBox.Show("Thiếu thông tin số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                KhachhangSelectSdt();
                txtmakh.Text = datakhachhang.Rows[0].Cells[0].Value.ToString();
                txttenkh.Text = datakhachhang.Rows[0].Cells[1].Value.ToString();
                dtpngaysinh.Text = datakhachhang.Rows[0].Cells[2].Value.ToString();
                txtdiachi.Text = datakhachhang.Rows[0].Cells[3].Value.ToString();
                txtsdt.Text = datakhachhang.Rows[0].Cells[4].Value.ToString();
                cbloaikh.Text = datakhachhang.Rows[0].Cells[5].Value.ToString();
                txtghichu.Text = datakhachhang.Rows[0].Cells[7].Value.ToString();
            }
        }

        private void btnsuasp_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Thiếu thông tin mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                KhachhangUpdate();
                KhachhangSelectSdt();
            }
        }

        private void btnxoasp_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Thiếu thông tin mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult hoi = MessageBox.Show("Bạn có chắc chắn muốn xóa không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hoi == DialogResult.Yes)
                {
                    KhachhangDelete();
                    KhachhangSelectSdt();
                }
            }
        }

        private void btnchapnhan_Click(object sender, EventArgs e)
        {
            KhachhangChapnhan();
        }


        public void KhachhangSelect()
        {
            datakhachhang.DataSource = khachhang_bus.KhachhangSelect();
            
        }
        public void KhachhangInsert()
        {
            KhachHangDTO khachhang = new KhachHangDTO();
            khachhang.MaKh = txtmakh.Text;
            khachhang.TenKh = txttenkh.Text;
            khachhang.NgaySinh = dtpngaysinh.Value.ToString();
            khachhang.DiaChi = txtdiachi.Text;
            khachhang.SDt = txtsdt.Text;
            khachhang.GhiChu = txtghichu.Text;
            string thongbao = khachhang_bus.KhachhangInsert(khachhang);
            MessageBox.Show("" + thongbao + "", "Thông báo", MessageBoxButtons.OK);
        }
        public void KhachhangUpdate()
        {
            KhachHangDTO khachhang = new KhachHangDTO();
            khachhang.MaKh = txtmakh.Text;
            khachhang.TenKh = txttenkh.Text;
            khachhang.NgaySinh = dtpngaysinh.Value.ToString();
            khachhang.DiaChi = txtdiachi.Text;
            khachhang.SDt = txtsdt.Text;
            khachhang.GhiChu = txtghichu.Text;
            int thongbao = khachhang_bus.KhachhangUpdate(khachhang);
            if (thongbao == 0)
            {
                MessageBox.Show("Sửa thông tin khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (thongbao == 1)
            {
                MessageBox.Show("Số điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Sửa thông tin khách hàng bị lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void KhachhangDelete()
        {
            KhachHangDTO khachhang = new KhachHangDTO();
            khachhang.MaKh = txtmakh.Text;
            if (khachhang_bus.KhachhangDelete(khachhang) == true)
            {
                MessageBox.Show("Xóa thông tin khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thông tin khách hàng bị lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void KhachhangChapnhan()
        {
            KhachHangDTO khachhang = new KhachHangDTO();
            if(txtmakh.Text != "" || txtsdt.Text != "")
            {
                khachhang.MaKh = txtmakh.Text;
                khachhang.SDt = txtsdt.Text;
                DataTable dt = khachhang_bus.KhachhangChapnhan(khachhang);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Thông tin khách hàng không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    makh = dt.Rows[0][0].ToString();
                    tenkh = dt.Rows[0][1].ToString();
                    string loaikh = dt.Rows[0][5].ToString();
                    if (loaikh == "Sơ cấp")
                    {
                        ptchietkhau = "10";
                    }
                    else if (loaikh == "Trung cấp")
                    {
                        ptchietkhau = "20";
                    }
                    else if(loaikh == "Cao cấp")
                    {
                        ptchietkhau = "30";
                    }
                    else
                    {
                        ptchietkhau = "0";
                    }

                    MessageBox.Show("Khách hàng được giảm giá " + ptchietkhau + "% ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BanHang bn = new BanHang(tendn,tenchutk, makh,tenkh, ptchietkhau,quyen);
                    this.Hide();
                    bn.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Nhập thiếu thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void clear()
        {
            txtmakh.Text = "";
            txttenkh.Text = "";
            txtsdt.Text = "";
            txtdiachi.Text = "";
            txtghichu.Text = "";
            cbloaikh.Text = "Sơ cấp";
        }
        public void KhachhangSelectSdt()
        {
            KhachHangDTO khachhang = new KhachHangDTO();
            khachhang.SDt = txtsdt.Text;
            datakhachhang.DataSource = khachhang_bus.KhachhangSelectSdt(khachhang);
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

        private void clicktxt(object sender, EventArgs e)
        {
            this.txttenkh.SelectAll();
            this.txtmakh.SelectAll();
            this.txtdiachi.SelectAll();
            this.txtsdt.SelectAll();
            this.txtghichu.SelectAll();
        }
        

        private void tat(object sender, FormClosedEventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có thực sự muốn thoát khỏi ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                BanHang bn = new BanHang(tendn,tenchutk ,"","", "",quyen);
                this.Hide();
                bn.ShowDialog();
            }
        }

        private void cbloaikh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
