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
    public partial class ThemLoaiSp : Form
    {
        SanPhamBUS sanpham_bus = new SanPhamBUS();
        LoaiSanPhamBUS loaisanpham_bus = new LoaiSanPhamBUS();
        public ThemLoaiSp()
        {
            InitializeComponent();
            listMaLoaiSp();
        }
        public void listMaLoaiSp()
        {
            cbmaloai.DataSource = loaisanpham_bus.listLoaiSp();
            cbmaloai.DisplayMember = "MALOAISP";
        }

        public void LoaiSpInsert()
        {
            LoaiSanPham lsp = new LoaiSanPham();
            lsp.MaLoaiSp = cbmaloai.Text;
            lsp.TenLoaiSp = txttenloai.Text;
            DataTable dt = loaisanpham_bus.LoaiSpInsert(lsp);
            MessageBox.Show(dt.Rows[0][0].ToString(), "Thông báo", MessageBoxButtons.OK);
        }
        public void LoaiSpDelete()
        {
            DialogResult hoi = MessageBox.Show("Xóa loại sản phẩm sẽ mất dữ liệu những sản phẩm, bạn có chắc chắn ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(hoi == DialogResult.Yes)
            {
                LoaiSanPham lsp = new LoaiSanPham();
                lsp.MaLoaiSp = cbmaloai.Text;
                DataTable dt = loaisanpham_bus.LoaiSpDelete(lsp);
                MessageBox.Show(dt.Rows[0][0].ToString(), "Thông báo", MessageBoxButtons.OK);
                txttenloai.Text = "";
            }
        }

        private void cbmaloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoaiSanPham lsp = new LoaiSanPham();
            lsp.MaLoaiSp = cbmaloai.Text;
            DataTable dt = loaisanpham_bus.listLoaiSp_SelectMa(lsp);
            txttenloai.Text = dt.Rows.Count == 0 ? "" : dt.Rows[0][1].ToString();
        }

        private void btnthommoi_Click(object sender, EventArgs e)
        {
            if(cbmaloai.Text =="" || txttenloai.Text == "")
            {
                MessageBox.Show("Nhập thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LoaiSpInsert();
                listMaLoaiSp();
            }

        }

        private void btnxoabo_Click(object sender, EventArgs e)
        {
            LoaiSpDelete();
            listMaLoaiSp();
        }

        private void clicktxt(object sender, EventArgs e)
        {
            this.cbmaloai.SelectAll();
            this.txttenloai.SelectAll();
        }
    }
}
