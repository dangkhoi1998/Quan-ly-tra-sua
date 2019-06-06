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
    public partial class DoiMatKhau : Form
    {
        public string TenDangNhap = "";
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        public DoiMatKhau(string tendn) : this()
        {
            this.TenDangNhap = tendn;
        }

        private TaiKhoanBUS taikhoan_bus = new TaiKhoanBUS();
        private void hienmatkhau_CheckedChanged(object sender, EventArgs e)
        {

            if (hienmatkhau.Checked == true)
            {
                txtmatkhaucu.UseSystemPasswordChar = false;
                txtmatkhaumoi.UseSystemPasswordChar = false;
                txtnhaplaimatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtmatkhaucu .UseSystemPasswordChar = true;
                txtmatkhaumoi.UseSystemPasswordChar = true;
                txtnhaplaimatkhau.UseSystemPasswordChar = true;
            }
        }

        private void btndoimk_Click(object sender, EventArgs e)
        {
            if(txtmatkhaumoi.Text != txtnhaplaimatkhau.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu sai !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TaiKhoan tk = new TaiKhoan();
                tk.TenDn = TenDangNhap;
                tk.MatKhau = txtmatkhaucu.Text;
                if (taikhoan_bus.Dangnhap(tk).Rows.Count > 0)
                {
                    tk.MatKhau = txtmatkhaumoi.Text;
                    if (taikhoan_bus.Doimatkhau(tk) == true)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtmatkhaumoi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
