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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void doanhThuTừngCaTheoTuầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            TKDoanhThu tkdoanhthu = new TKDoanhThu("doanhthutungcatrongngay");
            tkdoanhthu.MdiParent = this;
            tkdoanhthu.Show();
            tkdoanhthu.Location = new Point(1, 1);
        }

        private void doanhThuTừngTuầnTheoNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            TKDoanhThu tkdoanhthu = new TKDoanhThu("doanhthutungthangtrongnam");
            tkdoanhthu.MdiParent = this;
            tkdoanhthu.Show();
            tkdoanhthu.Location = new Point(1, 1);
        }

        private void doanhthutungngaytheothang_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            TKDoanhThu tkdoanhthu = new TKDoanhThu("doanhthutungngaytrongthang");
            tkdoanhthu.MdiParent = this;
            tkdoanhthu.Show();
            tkdoanhthu.Location = new Point(1, 1);
        }

        private void doanhthutungnam_Click(object sender, EventArgs e)
        {
            TKDtNam tkdt = new TKDtNam();
            TKDtNamIn tkdtin = new TKDtNamIn();
            tkdt.crvdoanhthunam.ReportSource = tkdtin;
            tkdt.ShowDialog();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            doanhThuTừngCaTheoTuầnToolStripMenuItem_Click(sender, e);
        }

        private void nguyênLiệuNhậpVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKNlNhap tknlp = new TKNlNhap();
            TKNlNhapIn tknlpin = new TKNlNhapIn();
            tknlp.crvnlnhap.ReportSource = tknlpin;
            tknlpin.Refresh();
            tknlp.ShowDialog();
        }

        private void nguyênLiệuHủyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKNlHuy tknlh = new TKNlHuy();
            TKNlHuyIn tknlhin = new TKNlHuyIn();
            tknlh.grvnlhuy.ReportSource = tknlhin;
            tknlh.Refresh();
            tknlh.ShowDialog();
        }
    }
}
