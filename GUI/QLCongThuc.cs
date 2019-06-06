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
    public partial class QLCongThuc : Form
    {
        private CongThucBUS congthuc_bus = new CongThucBUS();
        private NguyenLieuBUS nguyenlieu_bus = new NguyenLieuBUS();
        private SanPhamBUS sanpham_bus = new SanPhamBUS();
        private CtNguyenLieuBUS ctnl_bus = new CtNguyenLieuBUS();

        public QLCongThuc()
        {
            InitializeComponent();
            CongThuc_SelectAll();
            CongThuc_TenSpKoCt();
            NguyenLieu_Select();
            NguyenLieu_SelectDvt();
            SanPham_Select();
        }

        public void CongThuc_SelectAll()
        {
            datacongthuc.DataSource = congthuc_bus.CongThuc_SelectAll();
        }
        public void CongThuc_SelectAllMaSp()
        {
            CongThucDTO congthuc = new CongThucDTO();
            congthuc.MaSp = cbtensp.SelectedValue.ToString();
            datacongthuc.DataSource = congthuc_bus.CongThuc_SelectAllMaSp(congthuc);
        }
        public void CongThuc_TenSpKoCt()
        {
            dataspkoct.DataSource = congthuc_bus.CongThuc_TenSpKoCt();
        }

        public void CongThuc_Insert()
        {
            CongThucDTO congthuc = new CongThucDTO();
            congthuc.MaSp = cbtensp.Text;
            congthuc.MaNl = cbtennl.Text;
            congthuc.TieuHao = txttieuhao.Text;
            congthuc.DVt = cbdvt.Text;
            DataTable dt = congthuc_bus.CongThuc_Insert(congthuc);
            MessageBox.Show(dt.Rows[0][0].ToString(), "Thông báo", MessageBoxButtons.OK);
        }
        public void CongThuc_Update()
        {
            CongThucDTO congthuc = new CongThucDTO();
            congthuc.MaSp = cbtensp.Text;
            congthuc.MaNl = cbtennl.Text;
            congthuc.TieuHao = txttieuhao.Text;
            congthuc.DVt = cbdvt.Text;
            DataTable dt = congthuc_bus.CongThuc_Update(congthuc);
            MessageBox.Show(dt.Rows[0][0].ToString(), "Thông báo", MessageBoxButtons.OK);
        }
        public void CongThuc_Delete()
        {
            CongThucDTO congthuc = new CongThucDTO();
            congthuc.MaSp = cbtensp.Text;
            congthuc.MaNl = cbtennl.Text;
            congthuc.TieuHao = txttieuhao.Text;
            congthuc.DVt = cbdvt.Text;
            DataTable dt = congthuc_bus.CongThuc_Delete(congthuc);
            MessageBox.Show(dt.Rows[0][0].ToString(), "Thông báo", MessageBoxButtons.OK);
        }

        public void NguyenLieu_Select()
        {
            cbtennl.DataSource = nguyenlieu_bus.NguyenLieu_Select();
            cbtennl.DisplayMember = "TENNGUYENLIEU";
        }
        public void SanPham_Select()
        {
            cbtensp.DataSource = sanpham_bus.SanPham_Select();
            cbtensp.DisplayMember = "TENSANPHAM";
            cbtensp.ValueMember = "MASANPHAM";
        }

        public void NguyenLieu_SelectDvt()
        {
            cbdvt.DataSource = ctnl_bus.CtNguyenLieu_Dvt();
            cbdvt.DisplayMember = "DONVITINH";
        }
        public void kttxt()
        {
            if (cbtennl.Text == "" || cbtensp.Text == "" || cbdvt.Text == "" || txttieuhao.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Lượng tiêu hao phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void clear()
        {
            cbtennl.Text = "";
            cbdvt.Text = "";
            txttieuhao.Text = "";
        }

        private void clickdatacongthuc(object sender, DataGridViewCellEventArgs e)
        {
            cbtensp.Text = datacongthuc.CurrentRow.Cells[0].Value.ToString();
            cbtennl.Text = datacongthuc.CurrentRow.Cells[1].Value.ToString();
            cbdvt.Text = datacongthuc.CurrentRow.Cells[2].Value.ToString();
            txttieuhao.Text = datacongthuc.CurrentRow.Cells[3].Value.ToString();
        }

        private void clickdatasp(object sender, DataGridViewCellEventArgs e)
        {
            cbtensp.Text = dataspkoct.CurrentRow.Cells[0].Value.ToString();
            clear();
        }

        private void QLCongThuc_Load(object sender, EventArgs e)
        {
            CongThuc_SelectAll();
            clear();
            datacongthuc.Columns[0].HeaderText = "Tên sản phẩm";
            datacongthuc.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datacongthuc.Columns[0].Width = 250;
            datacongthuc.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datacongthuc.Columns[1].HeaderText = "Tên nguyên liệu";
            datacongthuc.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datacongthuc.Columns[1].Width = 200;
            datacongthuc.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datacongthuc.Columns[2].HeaderText = "Đơn vị tính";
            datacongthuc.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datacongthuc.Columns[2].Width = 116;
            datacongthuc.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datacongthuc.Columns[3].HeaderText = "Tiêu hao";
            datacongthuc.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datacongthuc.Columns[3].Width = 110;
            datacongthuc.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datacongthuc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataspkoct.Columns[0].HeaderText = "Tên sản phẩm";
            dataspkoct.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataspkoct.Columns[0].Width = 260;
            dataspkoct.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataspkoct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void cbtensp_SelectedIndexChanged(object sender, EventArgs e)
        {
            CongThuc_SelectAllMaSp();
        }


        private void btnload_Click(object sender, EventArgs e)
        {
            CongThuc_SelectAll();
            CongThuc_TenSpKoCt();
            clear();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                CongThuc_Insert();
                btnload_Click(sender, e);
            }
            catch
            {
                kttxt();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                CongThuc_Update();
                btnload_Click(sender, e);
            }
            catch
            {
                kttxt();
            } 
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có thật sự muốn xóa công thức ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(hoi == DialogResult.Yes)
            {
                try
                {
                    CongThuc_Delete();
                    btnload_Click(sender, e);
                }
                catch
                {
                    kttxt();
                }
            }
        }

        


        private void nhapso(object sender, KeyPressEventArgs e)
        {
            //if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }
        
    }
}
