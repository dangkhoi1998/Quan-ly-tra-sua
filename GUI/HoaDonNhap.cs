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
    public partial class HoaDonNhap : Form
    {
        public HoaDonNhap()
        {
            InitializeComponent();
        }
        private string TenDn;
        private string Quyen;
        public HoaDonNhap(string _tendn,string _quyen) : this()
        {
            TenDn = _tendn;
            Quyen = _quyen;
        }

        private void tat(object sender, FormClosedEventArgs e)
        {
            QLNguyenLieuNhap n = new QLNguyenLieuNhap("", TenDn,Quyen);
            this.Hide();
            n.ShowDialog();
        }
    }
}
