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
    public partial class QLNguyenLieu : Form
    {
        public string Quyen;
        private NguyenLieuBUS nguyenlieu_bus = new NguyenLieuBUS();
        private string TenDn;

        public QLNguyenLieu()
        {
            InitializeComponent();
            NguyenLieu_Select();
            NguyenLieu_SelectAll();
        }

        public QLNguyenLieu(string _tendn,string _quyen) : this()
        {
            TenDn = _tendn;
            Quyen = _quyen;
        }



        public void NguyenLieu_SelectAll()
        {
            DataTable dt = nguyenlieu_bus.NguyenLieu_SelectAll();
            datactnguyenlieu.DataSource = dt;
        }

        public void NguyenLieu_Select()
        {
            DataTable dt = nguyenlieu_bus.NguyenLieu_Select();
            cbnguyenlieu.DataSource = dt;
            cbnguyenlieu.DisplayMember = "TENNGUYENLIEU";
            cbnguyenlieu.ValueMember = "MANGUYENLIEU";
            txtnguyenlieu.Text = cbnguyenlieu.SelectedValue == null ? "" : cbnguyenlieu.SelectedValue.ToString();
            datanguyenlieu.DataSource = dt;
        }

        public void NguyenLieu_SelectAllMa(string manl)
        {
            NguyenLieuDTO nguyenlieu = new NguyenLieuDTO();
            nguyenlieu.MaNl = manl;
            DataTable dt = nguyenlieu_bus.NguyenLieu_SelectAllMa(nguyenlieu);
            datactnguyenlieu.DataSource = dt;
        }

        public void NguyenLieu_Insert()
        {
            NguyenLieuDTO nguyenlieu = new NguyenLieuDTO();
            nguyenlieu.MaNl = txtnguyenlieu.Text;
            nguyenlieu.TenNl = cbnguyenlieu.Text;
            DataTable dt = nguyenlieu_bus.NguyenLieu_Insert(nguyenlieu);
            MessageBox.Show(dt.Rows[0][0].ToString(), "Thông báo", MessageBoxButtons.OK);
        }

        public void NguyenLieu_Delete()
        {
            NguyenLieuDTO nguyenlieu = new NguyenLieuDTO();
            nguyenlieu.MaNl = cbnguyenlieu.SelectedValue.ToString();
            DataTable dt = nguyenlieu_bus.NguyenLieu_Delete(nguyenlieu);
            MessageBox.Show(dt.Rows[0][0].ToString(), "Thông báo", MessageBoxButtons.OK);
        }



        private void QLNguyenLieu_Load(object sender, EventArgs e)
        {
            datanguyenlieu.Columns[0].HeaderText = "Mã NL";
            datanguyenlieu.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datanguyenlieu.Columns[0].Width = 90;
            datanguyenlieu.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datanguyenlieu.Columns[1].HeaderText = "Tên nguyên liệu";
            datanguyenlieu.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datanguyenlieu.Columns[1].Width = 154;
            datanguyenlieu.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datanguyenlieu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            datactnguyenlieu.Columns[0].HeaderText = "Tên nguyên liệu";
            datactnguyenlieu.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datactnguyenlieu.Columns[0].Width = 205;
            datactnguyenlieu.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datactnguyenlieu.Columns[1].HeaderText = "Đơn vị tính";
            datactnguyenlieu.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datactnguyenlieu.Columns[1].Width = 85;
            datactnguyenlieu.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datactnguyenlieu.Columns[2].HeaderText = "Hạn sử dụng";
            datactnguyenlieu.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datactnguyenlieu.Columns[2].Width = 120;
            datactnguyenlieu.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            datactnguyenlieu.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datactnguyenlieu.Columns[3].HeaderText = "Tồn kho";
            datactnguyenlieu.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            datactnguyenlieu.Columns[3].Width = 114;
            datactnguyenlieu.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datactnguyenlieu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void cbnguyenlieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            NguyenLieu_SelectAllMa(cbnguyenlieu.SelectedValue.ToString());
            txtnguyenlieu.Text = cbnguyenlieu.SelectedValue.ToString();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            txtnguyenlieu.Text = "";
            cbnguyenlieu.Text = "";
            NguyenLieu_Select();
            NguyenLieu_SelectAll();
        }

        private void btnthemnl_Click(object sender, EventArgs e)
        {
            if(txtnguyenlieu.Text == "" || cbnguyenlieu.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                NguyenLieu_Insert();
                btnload_Click(sender, e);
            }
           
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtnguyenlieu.Text == "" || cbnguyenlieu.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                NguyenLieu_Delete();
                btnload_Click(sender, e);
            }
           
        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            QLNguyenLieuNhap qlnhapnl = new QLNguyenLieuNhap("",TenDn,Quyen);
            qlnhapnl.ShowDialog();
        }
        
        private void datanguyenlieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < datanguyenlieu.Rows.Count - 1; i++)
            {
                if (datanguyenlieu.Rows[i].Selected == true)
                {
                    NguyenLieu_SelectAllMa(datanguyenlieu.Rows[i].Cells[0].ToString().Trim());
                    break;
                }                
            }
        }

        private void clicktxt(object sender, EventArgs e)
        {
            this.txtnguyenlieu.SelectAll();
            this.cbnguyenlieu.SelectAll();
        }

        private void btnxuat_Click(object sender, EventArgs e)
        {
            QLNguyenLieuHuy qlnlh = new QLNguyenLieuHuy(TenDn);
            qlnlh.ShowDialog();
        }
    }
}
