using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class QuanLy : Form
    {
        public string Quyen;
        public string Tendn;
        public QuanLy()
        {
            InitializeComponent();
        }

        public QuanLy(string _tendn,string _quyen) : this()
        {
            Tendn = _tendn;
            Quyen = _quyen;
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            if(Quyen == "0")
            {
                btnsanpham.Visible = false;
                btncongthuc.Visible = false;
                btntaikhoan.Visible = false;
            }
            btnnguyenlieu_Click(sender,e);
        }

        private void btnsanpham_Click(object sender, EventArgs e)
        {

            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            QLSanPham qlsanpham = new QLSanPham();
            qlsanpham.MdiParent = this;
            qlsanpham.Show();
            qlsanpham.Location = new Point(1, 1);
        }

        private void btncongthuc_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            QLCongThuc qlcongthuc = new QLCongThuc();
            qlcongthuc.MdiParent = this;
            qlcongthuc.Show();
            qlcongthuc.Location = new Point(1, 1);
        }

        private void btntaikhoan_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            QLTaiKhoan qltk = new QLTaiKhoan();
            qltk.MdiParent = this;
            qltk.Show();
            qltk.Location = new Point(1, 1);

        }

        private void btnnguyenlieu_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            QLNguyenLieu qlnguyenlieu = new QLNguyenLieu(Tendn,Quyen);
            qlnguyenlieu.MdiParent = this;
            qlnguyenlieu.Show();
            qlnguyenlieu.Location = new Point(1, 1);

        }
    }
}
