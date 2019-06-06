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
    public partial class QLNguyenLieuNhap : Form
    {
        private NguyenLieuBUS nguyenlieu_bus = new NguyenLieuBUS();
        private CtNguyenLieuBUS ctnguyenlieu_bus = new CtNguyenLieuBUS();
        private NhapNguyenLieuBUS nhapnl_bus = new NhapNguyenLieuBUS();
        private CtNhapNguyenLieuBUS ctnhapnl_bus = new CtNhapNguyenLieuBUS();

        public string MaNhaCc = "";
        public string TenDn;
        public string Quyen;

        public QLNguyenLieuNhap()
        {
            InitializeComponent();
            Datachonnl();
            NguyenLieu_Select();
            CtNguyenLieu_Dvt();
        }

        public QLNguyenLieuNhap(string _manhacc,string _tendn, string _quyen) : this()
        {
            MaNhaCc = _manhacc;
            TenDn = _tendn;
            Quyen = _quyen;
        }

        public void Datachonnl()
        {
            datanlnhap.Columns[0].HeaderText = "Mã NL";
            datanlnhap.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datanlnhap.Columns[0].Width = 140;
            datanlnhap.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datanlnhap.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datanlnhap.Columns[1].HeaderText = "Tên nguyên liệu";
            datanlnhap.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datanlnhap.Columns[1].Width = 282;
            datanlnhap.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datanlnhap.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datanlnhap.Columns[2].HeaderText = "Đơn vị tính";
            datanlnhap.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datanlnhap.Columns[2].Width = 130;
            datanlnhap.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datanlnhap.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datanlnhap.Columns[3].HeaderText = "Hạn sử dụng";
            datanlnhap.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //datanlnhap.Columns[3].DefaultCellStyle.Format = "yyyy/MM/dd";
            datanlnhap.Columns[3].Width = 160;
            datanlnhap.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datanlnhap.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datanlnhap.Columns[4].HeaderText = "Số lượng";
            datanlnhap.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            datanlnhap.Columns[4].Width = 150;
            datanlnhap.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datanlnhap.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datanlnhap.Columns[5].HeaderText = "Đơn giá";
            datanlnhap.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            datanlnhap.Columns[5].Width = 165;
            datanlnhap.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datanlnhap.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datanlnhap.Columns[6].HeaderText = "Thành tiền";
            datanlnhap.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            datanlnhap.Columns[6].Width = 175;
            datanlnhap.Columns[6].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datanlnhap.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        public void NguyenLieu_Select()
        {
            DataTable dt = nguyenlieu_bus.NguyenLieu_Select();
            cbtennl.DataSource = dt;
            cbtennl.DisplayMember = "TENNGUYENLIEU";
            cbtennl.ValueMember = "MANGUYENLIEU";
        }

        public void CtNguyenLieu_Dvt()
        {
            DataTable dt = ctnguyenlieu_bus.CtNguyenLieu_Dvt();
            cbdvt.DataSource = dt;
            cbdvt.DisplayMember = "DONVITINH";
        }

        public void NguyenLieu_SelectAllMa()
        {
            NguyenLieuDTO nguyenlieu = new NguyenLieuDTO();
            nguyenlieu.MaNl = cbtennl.SelectedValue.ToString();
            DataTable dt = nguyenlieu_bus.NguyenLieu_SelectAllMa(nguyenlieu);
            cbdvt.Text = dt.Rows.Count == 0 ? "" : dt.Rows[0][1].ToString();
        }

        public void insertDatanlnhap(string manl, string tennl,string dvt,string hsd, string soluong, string dongia, string thanhtien)
        {
            String[] row = { manl, tennl, dvt, hsd, soluong.ToString(), dongia.ToString(), thanhtien.ToString()};
            //DataTable row = new DataTable(string masp, string tensp, string soluong, int gia, int thanhtien)
            datanlnhap.Rows.Add(row);
        }
        public void deleteDatanlnhap()
        {
            for (int i = 0; i < datanlnhap.Rows.Count; i++)
            {
                if (this.datanlnhap.Rows[i].Selected == true)
                {
                    //datachonsp.Rows.RemoveAt(this.datachonsp.SelectedRows[0].Index);
                    datanlnhap.Rows.RemoveAt(datanlnhap.CurrentCell.RowIndex);
                }
            }
        }

        public void clear()
        {
            txtsoluong.Text = "";
            txtdongia.Text = "";
        }

        public void ThanhToanNhap()
        {
            NhapNguyenLieuDTO nhapnl = new NhapNguyenLieuDTO();
            nhapnl.MaNcc = MaNhaCc;
            nhapnl.TenDn = TenDn ?? "admin";
            nhapnl.NgayNhap = dtpngaynhap.Value.ToString();
            nhapnl.TongTien = txttongtien.Text;
            bool t = nhapnl_bus.NhapNl_Insert(nhapnl);
            for (int i = 0; i < datanlnhap.Rows.Count - 1; i++)
            {
                CtNhapNguyenLieuDTO ctnhapnl = new CtNhapNguyenLieuDTO();
                ctnhapnl.MaNl = datanlnhap.Rows[i].Cells[0].Value.ToString();
                ctnhapnl.SoLuong = datanlnhap.Rows[i].Cells[4].Value.ToString();
                ctnhapnl.DonViTinh = datanlnhap.Rows[i].Cells[2].Value.ToString();
                ctnhapnl.HSd = datanlnhap.Rows[i].Cells[3].Value.ToString();
                ctnhapnl.DonGia = datanlnhap.Rows[i].Cells[5].Value.ToString();
                ctnhapnl_bus.CtNhapNl_Insert(ctnhapnl);

                //CtNguyenLieuDTO ctnl = new CtNguyenLieuDTO();
                //ctnl.MaNl = datanlnhap.Rows[i].Cells[0].Value.ToString();
                //ctnl.DVt = datanlnhap.Rows[i].Cells[2].Value.ToString();
                //ctnl.HSd = datanlnhap.Rows[i].Cells[3].Value.ToString();
                //ctnl.TonKho = datanlnhap.Rows[i].Cells[4].Value.ToString();
                //ctnhapnl_bus.CtNhapNl_InsertNl(ctnl);

            }

            CtNhapNl_InsertNl();

            HoaDonNhap hdn = new HoaDonNhap(TenDn,Quyen);
            HoaDonNhapp hdnp = new HoaDonNhapp();
            hdn.crvhoadonnhap.ReportSource = hdnp;
            this.Hide();
            hdn.ShowDialog();
        }

        public void CtNhapNl_InsertNl()
        {
            //DataGridView datanhapnl = new DataGridView();
            //datanhapnl.DataSource= ctnhapnl_bus.CtNhapNl_InHd();
            //for(int i= 0; i< datanhapnl.Rows.Count -1; i++)
            for (int i = 0; i < datanlnhap.Rows.Count - 1; i++)
            {
                CtNguyenLieuDTO ctnl = new CtNguyenLieuDTO();
                ctnl.MaNl = datanlnhap.Rows[i].Cells[0].Value.ToString();
                ctnl.DVt = datanlnhap.Rows[i].Cells[2].Value.ToString();
                ctnl.HSd = datanlnhap.Rows[i].Cells[3].Value.ToString();
                ctnl.TonKho = datanlnhap.Rows[i].Cells[4].Value.ToString();
                ctnhapnl_bus.CtNhapNl_InsertNl(ctnl);
            }
        }

        private void cbtennl_SelectedIndexChanged(object sender, EventArgs e)
        {
            NguyenLieu_SelectAllMa();
        }

        private void btnthemnl_Click(object sender, EventArgs e)
        {
            if (cbtennl.Text == "" || cbdvt.Text == "" || txtsoluong.Text == "" || txtdongia.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                insertDatanlnhap(cbtennl.SelectedValue.ToString(), cbtennl.Text, cbdvt.Text, dtphsd.Value.ToString("dd/MM/yyyy"), txtsoluong.Text, txtdongia.Text, (Convert.ToDouble(txtsoluong.Text) * Convert.ToDouble(txtdongia.Text)).ToString());
                clear();
                txttongtien_TextChanged(sender, e);
            }
        }

        

        private void btnxoanl_Click(object sender, EventArgs e)
        {
            deleteDatanlnhap();
            CtNguyenLieu_Dvt();
            txttongtien_TextChanged(sender, e);
        }

        private void txttongtien_TextChanged(object sender, EventArgs e)
        {
            int sumtien = 0;
            for (int i = 0; i < datanlnhap.RowCount - 1; i++)
            {
                sumtien += Convert.ToInt32(datanlnhap.Rows[i].Cells[6].Value.ToString());
            }
            double tongtien = Convert.ToDouble(sumtien.ToString());
            string t = string.Format("{0:0,0}", tongtien);
            txttongtien.Text = t;
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            clear();
            datanlnhap.Rows.Clear();
            txttongtien_TextChanged(sender, e);
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            if (datanlnhap.Rows.Count == 1)
            {
                MessageBox.Show("Chưa có nguyên liệu nào đc chọn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult hoi = MessageBox.Show("Bạn có chắc chắn muốn thanh toán ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(hoi == DialogResult.Yes)
                {
                    ThanhToanNhap();
                    btnload_Click(sender,e);
                }
            }
        }

        private void QLNguyenLieuNhap_Load(object sender, EventArgs e)
        {
            if(MaNhaCc == "")
            {
                cbtennl.Enabled = false;
                cbdvt.Enabled = false;
                dtphsd.Enabled = false;
                dtpngaynhap.Enabled = false;
                txtsoluong.Enabled = false;
                txtdongia.Enabled = false;
                btnthemnl.Enabled = false;
                btnxoanl.Enabled = false;
                btnload.Enabled = false;
                btnthanhtoan.Enabled = false;
            }
            datanlnhap.Rows.Clear();
        }

        private void nhapso(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void kothaydoi(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void clicktxt(object sender, EventArgs e)
        {
            this.cbdvt.SelectAll();
            this.txtdongia.SelectAll();
            this.txtsoluong.SelectAll();
        }

        private void btnnhacc_Click(object sender, EventArgs e)
        {
            NhaCungCap nhacc = new NhaCungCap(TenDn,Quyen);
            this.Hide();
            nhacc.ShowDialog();
        }
    }
}
