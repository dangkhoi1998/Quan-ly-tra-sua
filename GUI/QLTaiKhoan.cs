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
    public partial class QLTaiKhoan : Form
    {
        private TaiKhoanBUS taikhoan_bus = new TaiKhoanBUS();

        public QLTaiKhoan()
        {
            InitializeComponent();
            TaiKhoan_SelectAll();
        }

        public TaiKhoan Nhapdulieu()
        {
            TaiKhoan taikhoan = new TaiKhoan();
            taikhoan.TenDn = txttendn.Text;
            taikhoan.MatKhau = txtmatkhau.Text;
            taikhoan.ChuTk = cbtenchutk.Text;
            taikhoan.Quyen = cbquyen.Text;
            return taikhoan;
        }

        public void TaiKhoan_SelectAll()
        {
            cbtenchutk.DataSource = taikhoan_bus.TaiKhoan_SelectAll();
            cbtenchutk.DisplayMember = "TENCHUTAIKHOAN";
            cbquyen.DataSource = taikhoan_bus.TaiKhoan_SelectAll();
            cbquyen.DisplayMember = "QUYEN";
            datataikhoan.DataSource = taikhoan_bus.TaiKhoan_SelectAll();
        }

        public void TaiKhoan_SelectAllTen()
        {
            datataikhoan.DataSource = taikhoan_bus.TaiKhoan_SelectAllTen(Nhapdulieu());
        }

        public void TaiKhoan_Insert()
        {
            DataTable dt = taikhoan_bus.TaiKhoan_Insert(Nhapdulieu());
            if(dt != null)
            {
                MessageBox.Show(dt.Rows[0][0].ToString(), "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Thêm tài khoản bị lỗi", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void TaiKhoan_Delete()
        {
            DataTable dt = taikhoan_bus.TaiKhoan_Delete(Nhapdulieu());
            if (dt != null)
            {
                MessageBox.Show(dt.Rows[0][0].ToString(), "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Xóa tài khoản bị lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clear()
        {
            txtmatkhau.Text = "";
            txttendn.Text = "";
            cbquyen.Text = "";
        }

        private void QLTaiKhoan_Load(object sender, EventArgs e)
        {
            clear();
            datataikhoan.Columns[0].HeaderText = "Tên chủ tài khoản";
            datataikhoan.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datataikhoan.Columns[0].Width = 298;
            datataikhoan.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datataikhoan.Columns[1].HeaderText = "Tên đăng nhập";
            datataikhoan.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datataikhoan.Columns[1].Width = 240;
            datataikhoan.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datataikhoan.Columns[2].HeaderText = "Mức quyền";
            datataikhoan.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datataikhoan.Columns[2].Width = 130;
            datataikhoan.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datataikhoan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void cbtenchutk_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaiKhoan_SelectAllTen();
            clear();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            TaiKhoan_SelectAll();
            clear();
        }

        private void clickdatatk(object sender, DataGridViewCellEventArgs e)
        {
            cbtenchutk.Text = datataikhoan.CurrentRow.Cells[0].Value.ToString();
            txttendn.Text = datataikhoan.CurrentRow.Cells[1].Value.ToString();
            cbquyen.Text = datataikhoan.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if(txtmatkhau.Text == "" || txttendn.Text == "" || cbquyen.Text == "" || cbtenchutk.Text == "")
            {
                MessageBox.Show("Nhập thiếu dữ liệu !", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                TaiKhoan_Insert();
                btnload_Click(sender,e);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txttendn.Text == "")
            {
                MessageBox.Show("Nhập thiếu dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TaiKhoan_Delete();
                btnload_Click(sender, e);
            }
        }
    }
}
