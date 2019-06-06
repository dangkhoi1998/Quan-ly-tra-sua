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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private TaiKhoanBUS taikhoan_bus = new TaiKhoanBUS();

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if(txtmatkhau.Text != "" || txttendangnhap.Text != "")
            {
                TaiKhoan tk = new TaiKhoan();
                tk.TenDn = txttendangnhap.Text;
                tk.MatKhau = txtmatkhau.Text;
                DataTable dt = taikhoan_bus.Dangnhap(tk);

                if (dt.Rows.Count > 0)
                {
                    Chinh chinh = new Chinh(dt.Rows[0][0].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    chinh.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nhập thiếu thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void hienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            //if(hienmatkhau.Checked == true)
            //{
            //    txtmatkhau.UseSystemPasswordChar = false;
            //}
            //else
            //{
            //    txtmatkhau.UseSystemPasswordChar = true;
            //}
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hienmatkhau_CheckedChanged_1(object sender, EventArgs e)
        {
            if (hienmatkhau.Checked == true)
            {
                txtmatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtmatkhau.UseSystemPasswordChar = true;
            }
        }
    }
}
