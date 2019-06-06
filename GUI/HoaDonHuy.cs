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
    public partial class HoaDonHuy : Form
    {
        public HoaDonHuy()
        {
            InitializeComponent();
        }
        private string TenDn;

        public HoaDonHuy(string _tendn) : this()
        {
            TenDn = _tendn;
        }
        private void tat(object sender, FormClosedEventArgs e)
        {
            QLNguyenLieuHuy qlnlh = new QLNguyenLieuHuy(TenDn);
            this.Hide();
            qlnlh.ShowDialog();
        }
    }
}
