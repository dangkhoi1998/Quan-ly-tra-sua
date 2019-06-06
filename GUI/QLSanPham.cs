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
    public partial class QLSanPham : Form
    {
        LoaiSanPhamBUS loaisp_bus = new LoaiSanPhamBUS();
        SanPhamBUS sanpham_bus = new SanPhamBUS();
        public QLSanPham()
        {
            InitializeComponent();
            listLoaiSp();
            listSanPham();
            listSanPham_All();
        }

        public void listLoaiSp()
        {
            cbloaisp.DataSource = loaisp_bus.listLoaiSp();
            cbloaisp.DisplayMember = "TENLOAISP";
            cbloaisp.ValueMember = "MALOAISP";
        }
        public void listSanPham()
        {
            cbtensp.DataSource = sanpham_bus.SanPham_Select();
            cbtensp.DisplayMember = "TENSANPHAM";
            cbtensp.ValueMember = "MASANPHAM";
        }

        public void listSanPham_All()
        {
            datasanpham.DataSource = sanpham_bus.SanPham_Select();
        }

        public void listSanPham_MaLoaiSp()
        {
            SanPham sanpham = new SanPham();
            string maloaisp = Convert.ToString(cbloaisp.SelectedValue);
            sanpham.MaLoaiSp = maloaisp;
            datasanpham.DataSource = sanpham_bus.listSanPham_MaLoaiSp(sanpham);
        }

        public void listSanPham_MaSp()
        {
            SanPham sanpham = new SanPham();
            string masp = Convert.ToString(cbtensp.SelectedValue);
            sanpham.MaSanPham = masp;
            datasanpham.DataSource = sanpham_bus.listSanPham_MaSp(sanpham);
        }
        public void SanPham_insert()
        {
            SanPham sanpham = new SanPham();
            sanpham.MaSanPham = txtmasp.Text;
            sanpham.TenSanPham = cbtensp.Text;
            sanpham.Gia = txtgia.Text;
            sanpham.ThongTin = txtghichu.Text;
            sanpham.MaLoaiSp = cbloaisp.SelectedValue.ToString();
            DataTable dt = sanpham_bus.SanPham_Insert(sanpham);
            MessageBox.Show(dt.Rows[0][0].ToString(), "Thông báo", MessageBoxButtons.OK);
        }
        public void SanPham_Update()
        {
            SanPham sanpham = new SanPham();
            sanpham.MaSanPham = txtmasp.ToString();
            sanpham.Gia = txtgia.Text;
            sanpham.ThongTin = txtghichu.Text;
            DataTable dt = sanpham_bus.SanPham_Update(sanpham);
            MessageBox.Show(dt.Rows[0][0].ToString(), "Thông báo", MessageBoxButtons.OK);
        }
        public void SanPham_Delete()
        {
            SanPham sanpham = new SanPham();
            sanpham.MaSanPham = cbtensp.SelectedValue.ToString();
            DataTable dt = sanpham_bus.SanPham_Delete(sanpham);
            MessageBox.Show(dt.Rows[0][0].ToString(), "Thông báo", MessageBoxButtons.OK);
        }
        public void clear()
        {
            cbtensp.Text = "";
            txtmasp.Text = "";
            txtgia.Text = "";
            txtghichu.Text = "";
        }
        

        private void QLSanPham_Load(object sender, EventArgs e)
        {
            listSanPham_All();
            datasanpham.Columns[0].HeaderText = "Mã LSP";
            datasanpham.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datasanpham.Columns[0].Width = 70;
            datasanpham.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datasanpham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datasanpham.Columns[1].HeaderText = "Tên loại SP";
            datasanpham.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datasanpham.Columns[1].Width = 120;
            datasanpham.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datasanpham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datasanpham.Columns[2].HeaderText = "Mã sản phẩm";
            datasanpham.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datasanpham.Columns[2].Width = 80;
            datasanpham.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datasanpham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datasanpham.Columns[3].HeaderText = "Tên sản phẩm";
            datasanpham.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datasanpham.Columns[3].Width = 250;
            datasanpham.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datasanpham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datasanpham.Columns[4].HeaderText = "Đơn giá";
            datasanpham.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            datasanpham.Columns[4].Width = 100;
            datasanpham.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datasanpham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datasanpham.Columns[5].HeaderText = "Thông tin";
            datasanpham.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datasanpham.Columns[5].Width = 150;
            datasanpham.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datasanpham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        

        private void btnload_Click(object sender, EventArgs e)
        {
            listLoaiSp();
            listSanPham();
            clear();
            listSanPham_All();
        }

        private void cbloaisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            listSanPham_MaLoaiSp();
            clear();
        }

        private void btnthemloaisp_Click(object sender, EventArgs e)
        {
            ThemLoaiSp tl = new ThemLoaiSp();
            tl.ShowDialog();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            //try
            {
                if (txtmasp.Text == "" || cbtensp.Text == "" || txtgia.Text == "" || txtghichu.Text == "")
                {
                    MessageBox.Show("Không để trống thông tin sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SanPham_insert();
                    listSanPham_All();
                    listSanPham();
                    clear();
                }
            }
            //catch
            //{
            //    MessageBox.Show("Mã sản phẩm không được viết có dấu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if(cbtensp.Text == "" || txtgia.Text =="" || txtghichu.Text== "")
            {
                MessageBox.Show("Không để trống thông tin sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult hoi = MessageBox.Show("Bạn thật sự muốn sửa thông tin sản phẩm ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hoi == DialogResult.Yes)
                {
                    SanPham_Update();
                    listSanPham_All();
                    listSanPham();
                    clear();
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (cbtensp.Text == "")
            {
                MessageBox.Show("Không để trống tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult hoi = MessageBox.Show("Bạn thật sự muốn xóa sản phẩm ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(hoi == DialogResult.Yes)
                {
                    SanPham_Delete();
                    listSanPham_All();
                    listSanPham();
                    clear();
                }
            }
        }

        private void cbtensp_SelectedIndexChanged(object sender, EventArgs e)
        {
            listSanPham_MaSp();
            //cbloaisp.Text = datasanpham.Rows[0].Cells[1].Value.ToString();
            //txtmasp.Text = datasanpham.Rows[0].Cells[2].Value.ToString();
            //cbtensp.Text = datasanpham.Rows[0].Cells[3].Value.ToString();
            //txtgia.Text = datasanpham.Rows[0].Cells[4].Value.ToString();
            //txtghichu.Text = datasanpham.Rows[0].Cells[5].Value.ToString();
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
            this.cbtensp.SelectAll();
            this.txtmasp.SelectAll();
            this.txtgia.SelectAll();
            this.txtghichu.SelectAll();
        }

        private void nhapso(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
    }
}
