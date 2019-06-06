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
    public partial class QLNguyenLieuHuy : Form
    {
        private NguyenLieuBUS nguyenlieu_bus = new NguyenLieuBUS();
        private HuyNguyenLieuBUS huynl_bus = new HuyNguyenLieuBUS();
        private CtHuyNguyenLieuBUS cthuynl_bus = new CtHuyNguyenLieuBUS();

        private string TenDn;
        public QLNguyenLieuHuy()
        {
            InitializeComponent();
            NguyenLieu_Select();
            NguyenLieu_SelectAll();
        }

        public QLNguyenLieuHuy(string _tendn) : this()
        {
            TenDn = _tendn;
        }

        public void NguyenLieu_Select()
        {
            DataTable dt = nguyenlieu_bus.NguyenLieu_Select();
            cbtennl.DataSource = dt;
            cbtennl.DisplayMember = "TENNGUYENLIEU";
            cbtennl.ValueMember = "MANGUYENLIEU";
        }

        public void NguyenLieu_SelectAll()
        {
            DataTable dt = nguyenlieu_bus.NguyenLieu_SelectAll();
            datanguyenlieukho.DataSource = dt;
        }

        public void NguyenLieu_SelectAllMa()
        {
            NguyenLieuDTO nguyenlieu = new NguyenLieuDTO();
            nguyenlieu.MaNl = cbtennl.SelectedValue.ToString();
            DataTable dt = nguyenlieu_bus.NguyenLieu_SelectAllMa(nguyenlieu);
            datanguyenlieukho.DataSource = dt;
        }

        public void insertDatanlnhap(string tennl, string dvt,string soluonghuy, string hsd, string lydohuy)
        {
            String[] row = { tennl, dvt, soluonghuy.ToString(), hsd, lydohuy };
            //DataTable row = new DataTable(string masp, string tensp, string soluong, int gia, int thanhtien)
            datanguyenlieuhuy.Rows.Add(row);
        }

        public void clear()
        {
            txtsoluonghuy.Text = "";
            txtlydohuy.Text = "";
        }

        public void deleteDatanlhuy()
        {
            for (int i = 0; i < datanguyenlieuhuy.Rows.Count; i++)
            {
                if (this.datanguyenlieuhuy.Rows[i].Selected == true)
                {
                    //datachonsp.Rows.RemoveAt(this.datachonsp.SelectedRows[0].Index);
                    datanguyenlieuhuy.Rows.RemoveAt(datanguyenlieuhuy.CurrentCell.RowIndex);
                }
            }
        }

        public void HuyNl()
        {
            HuyNguyenLieuDTO huynl = new HuyNguyenLieuDTO();
            huynl.TenDn = TenDn ?? "admin";
            bool t = huynl_bus.HuyNl_Insert(huynl);
            for (int i = 0; i < datanguyenlieuhuy.Rows.Count - 1; i++)
            {
                CtHuyNguyenLieuDTO cthuynl = new CtHuyNguyenLieuDTO();
                cthuynl.MaNl = datanguyenlieuhuy.Rows[i].Cells[0].Value.ToString();
                cthuynl.DVt = datanguyenlieuhuy.Rows[i].Cells[1].Value.ToString();
                cthuynl.SoLuong = datanguyenlieuhuy.Rows[i].Cells[2].Value.ToString();
                cthuynl.HSd = datanguyenlieuhuy.Rows[i].Cells[3].Value.ToString();
                cthuynl.LyDoHuy = datanguyenlieuhuy.Rows[i].Cells[4].Value.ToString();
                cthuynl_bus.CtHuyNl_Insert(cthuynl);
            }
            CtHuyNl_DeleteNl();
            HoaDonHuy hdh = new HoaDonHuy(TenDn);
            HoaDonHuyy hdhy = new HoaDonHuyy();
            hdh.crvhoadonhuy.ReportSource = hdhy;
            this.Hide();
            hdh.ShowDialog();
        }

        public void CtHuyNl_DeleteNl()
        {
            //DataGridView datanhapnl = new DataGridView();
            //datanhapnl.DataSource= ctnhapnl_bus.CtNhapNl_InHd();
            //for(int i= 0; i< datanhapnl.Rows.Count -1; i++)
            for (int i = 0; i < datanguyenlieuhuy.Rows.Count - 1; i++)
            {
                CtNguyenLieuDTO ctnl = new CtNguyenLieuDTO();
                ctnl.MaNl = datanguyenlieuhuy.Rows[i].Cells[0].Value.ToString();
                ctnl.DVt = datanguyenlieuhuy.Rows[i].Cells[1].Value.ToString();
                ctnl.HSd = datanguyenlieuhuy.Rows[i].Cells[3].Value.ToString();
                ctnl.TonKho = datanguyenlieuhuy.Rows[i].Cells[2].Value.ToString();
                bool t = cthuynl_bus.CtHuyNl_DeleteNl(ctnl);
            }
        }

        public string convertdate(string _date)
        {
            string ngay = "", thang = "", nam = "";
            if (_date.Length == 22)
            {
                ngay = _date.Substring(3, 2);
                thang = _date.Substring(0, 2);
                nam = _date.Substring(6, 4);
            }
            else if (_date.Length == 21)
            {
                if (_date.Substring(3, 1) == "/")
                {
                    ngay = _date.Substring(3, 2);
                    thang = "0" + _date.Substring(0, 1);
                }
                else
                {
                    ngay = "0" + _date.Substring(3, 1);
                    thang = _date.Substring(0, 2);
                }
                nam = _date.Substring(5, 4);
            }
            else if (_date.Length == 20)
            {
                ngay = _date.Substring(3, 2);
                ngay = "0" + _date.Substring(2, 1);
                thang = "0" + _date.Substring(0, 1);
                nam = _date.Substring(4, 4);
            }
            return ngay + "/" + thang + "/" + nam;
        }

        public string KtNl()
        {
            string kt = null;
            for (int i = 0;i< datanguyenlieuhuy.RowCount - 1; i++)
            {
                string tennl = datanguyenlieuhuy.Rows[i].Cells[0].Value.ToString();
                string dvt = datanguyenlieuhuy.Rows[i].Cells[1].Value.ToString();
                double slhuy = Convert.ToDouble(datanguyenlieuhuy.Rows[i].Cells[2].Value.ToString());
                string hsd = datanguyenlieuhuy.Rows[i].Cells[3].Value.ToString();
                for(int j=0; j < i; j++)
                {
                    if(datanguyenlieuhuy.Rows[j].Cells[0].Value.ToString() == tennl && datanguyenlieuhuy.Rows[j].Cells[1].Value.ToString() == dvt 
                        && datanguyenlieuhuy.Rows[j].Cells[3].Value.ToString() == hsd)
                    {
                        slhuy =+ Convert.ToDouble(datanguyenlieuhuy.Rows[j].Cells[2].Value.ToString());
                    }
                }
                for(int j= 0;j<datanguyenlieukho.RowCount -1; j++)
                {
                    if (datanguyenlieukho.Rows[j].Cells[0].Value.ToString() == tennl && datanguyenlieukho.Rows[j].Cells[1].Value.ToString() == dvt
                        && convertdate(datanguyenlieukho.Rows[j].Cells[2].Value.ToString()) == hsd)
                    {
                        if(slhuy > Convert.ToDouble(datanguyenlieukho.Rows[j].Cells[3].Value.ToString()))
                        {
                            kt = tennl;
                        }
                    }
                }
            }
            return kt;
        }

        private void QLNguyenLieuHuy_Load(object sender, EventArgs e)
        {
            datanguyenlieukho.Columns[0].HeaderText = "Tên nguyên liệu";
            datanguyenlieukho.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datanguyenlieukho.Columns[0].Width = 206;
            datanguyenlieukho.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datanguyenlieukho.Columns[1].HeaderText = "Đơn vị tính";
            datanguyenlieukho.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datanguyenlieukho.Columns[1].Width = 85;
            datanguyenlieukho.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datanguyenlieukho.Columns[2].HeaderText = "Hạn sử dụng";
            datanguyenlieukho.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datanguyenlieukho.Columns[2].Width = 120;
            datanguyenlieukho.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            datanguyenlieukho.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datanguyenlieukho.Columns[3].HeaderText = "Tồn kho";
            datanguyenlieukho.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            datanguyenlieukho.Columns[3].Width = 115;
            datanguyenlieukho.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datanguyenlieukho.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            datanguyenlieuhuy.Columns[0].HeaderText = "Tên nguyên liệu";
            datanguyenlieuhuy.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datanguyenlieuhuy.Columns[0].Width = 206;
            datanguyenlieuhuy.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datanguyenlieuhuy.Columns[1].HeaderText = "Đơn vị tính";
            datanguyenlieuhuy.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datanguyenlieuhuy.Columns[1].Width = 85;
            datanguyenlieuhuy.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datanguyenlieuhuy.Columns[2].HeaderText = "Số lượng hủy";
            datanguyenlieuhuy.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            datanguyenlieuhuy.Columns[2].Width = 90;
            datanguyenlieuhuy.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datanguyenlieuhuy.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datanguyenlieuhuy.Columns[3].HeaderText = "Hạn sử dụng";
            datanguyenlieuhuy.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datanguyenlieuhuy.Columns[3].Width = 110;
            datanguyenlieuhuy.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            datanguyenlieuhuy.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datanguyenlieuhuy.Columns[4].HeaderText = "Lý do hủy";
            datanguyenlieuhuy.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datanguyenlieuhuy.Columns[4].Width = 200;
            datanguyenlieuhuy.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datanguyenlieuhuy.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void cbtennl_SelectedIndexChanged(object sender, EventArgs e)
        {
            NguyenLieu_SelectAllMa();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            clear();
            datanguyenlieuhuy.Rows.Clear();
            NguyenLieu_SelectAll();
        }

        private void btnloadnl_Click(object sender, EventArgs e)
        {
            NguyenLieu_SelectAll();
        }

        private void loadnlhuy_Click(object sender, EventArgs e)
        {
            datanguyenlieuhuy.Rows.Clear();
        }

        private void btnthemnl_Click(object sender, EventArgs e)
        {
            if (cbtennl.Text == "" || txtsoluonghuy.Text == "" || txtlydohuy.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                for (int i = 0; i < datanguyenlieukho.Rows.Count; i++)
                {
                    try
                    {
                        if (this.datanguyenlieukho.Rows[i].Selected == true)
                        {
                            if (Convert.ToDouble(datanguyenlieukho.Rows[i].Cells[3].Value.ToString()) < Convert.ToDouble(txtsoluonghuy.Text))
                            {
                                MessageBox.Show("Số lượng tồn kho không đủ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (txtsoluonghuy.Text == "0")
                            {
                                MessageBox.Show("Số lượng hủy bằng 0 ???", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                string tennl = datanguyenlieukho.Rows[i].Cells[0].Value.ToString();
                                string dvt = datanguyenlieukho.Rows[i].Cells[1].Value.ToString();
                                string soluonghuy = txtsoluonghuy.Text;
                                string lydohuy = txtlydohuy.Text;
                                string hsd = datanguyenlieukho.Rows[i].Cells[2].Value.ToString();
                                insertDatanlnhap(tennl, dvt, soluonghuy, convertdate(hsd), lydohuy);
                                clear();
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Thêm nguyên liệu bị lỗi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnxoanl_Click(object sender, EventArgs e)
        {
            deleteDatanlhuy();
        }

        private void btnlapphieu_Click(object sender, EventArgs e)
        {
            if (datanguyenlieuhuy.Rows.Count == 1)
            {
                MessageBox.Show("Chưa có nguyên liệu nào đc chọn hủy !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult hoi = MessageBox.Show("Bạn có chắc chắn muốn hủy nguyên liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hoi == DialogResult.Yes)
                {
                    if (KtNl() == null)
                    {
                        HuyNl();
                        btnload_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Số lượng nguyên liệu "+KtNl().ToString()+" tồn kho không đủ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

    }
}
