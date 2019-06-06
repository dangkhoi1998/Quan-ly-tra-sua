using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DTO;
using BUS;

namespace GUI
{
    public partial class KhoaSo : Form
    {
        HoaDonBUS hoadon_bus = new HoaDonBUS();
        DoanhThuBUS doanhthu_bus = new DoanhThuBUS();
        public KhoaSo()
        {
            InitializeComponent();
        }

        private string tenDn;

        public string TenDn
        {
            get
            {
                return tenDn;
            }

            set
            {
                tenDn = value;
            }
        }

        private void crvkhoaso_Load(object sender, EventArgs e)
        {

        }

        private void btnin_Click(object sender, EventArgs e)
        {
            DoanhthuInsert();
        }

        public void DoanhthuInsert()
        {
            TaiKhoan taikhoan = new TaiKhoan();
            taikhoan.TenDn = TenDn;
            if(doanhthu_bus.DoanhthuInsert(taikhoan) == true)
            {
                MessageBox.Show( "Khóa sổ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Không thể khóa sổ, gặp lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
