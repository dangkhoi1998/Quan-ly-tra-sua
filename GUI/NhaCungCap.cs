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
    public partial class NhaCungCap : Form
    {
        public NhaCungCapBUS nhacc_bus = new NhaCungCapBUS();

        private string TenDn;
        private string Quyen;

        public NhaCungCap()
        {
            InitializeComponent();
            NhaCc_Select();
        }

        public NhaCungCap(string _tendn, string _quyen) : this()
        {
            TenDn = _tendn;
            Quyen = _quyen;
        }

        public void NhaCc_Select()
        {
            datanhacc.DataSource = nhacc_bus.NhaCc_Select();
            cbtennhacc.DataSource = nhacc_bus.NhaCc_Select();
            cbtennhacc.DisplayMember = "TENNCC";
            cbtennhacc.ValueMember = "MANCC";
        }

        public void NhaCc_SelectMa()
        {
            NhaCungCapDTO nhacc = new NhaCungCapDTO();
            nhacc.MaNhaCc = cbtennhacc.SelectedValue.ToString();
            datanhacc.DataSource = nhacc_bus.NhaCc_SelectMa(nhacc);
            txtmanhacc.Text = datanhacc.Rows[0].Cells[0].Value.ToString();
            txtsdt.Text = datanhacc.Rows[0].Cells[2].Value.ToString();
            txtdiachi.Text = datanhacc.Rows[0].Cells[3].Value.ToString();
        }

        public void NhaCc_Insert()
        {
            NhaCungCapDTO nhacc = new NhaCungCapDTO();
            nhacc.MaNhaCc = txtmanhacc.Text;
            nhacc.TenNhaCc = cbtennhacc.Text;
            nhacc.SDt = txtsdt.Text;
            nhacc.DiaChi = txtdiachi.Text;
            DataTable dt = nhacc_bus.NhaCc_Insert(nhacc);
            MessageBox.Show(dt.Rows[0][0].ToString(), "Thông báo", MessageBoxButtons.OK);
        }

        public void NhaCc_Update()
        {
            NhaCungCapDTO nhacc = new NhaCungCapDTO();
            nhacc.MaNhaCc = txtmanhacc.Text;
            nhacc.TenNhaCc = cbtennhacc.Text;
            nhacc.SDt = txtsdt.Text;
            nhacc.DiaChi = txtdiachi.Text;
            DataTable dt = nhacc_bus.NhaCc_Update(nhacc);
            MessageBox.Show(dt.Rows[0][0].ToString(), "Thông báo", MessageBoxButtons.OK);
        }

        public void NhaCc_Delete()
        {
            NhaCungCapDTO nhacc = new NhaCungCapDTO();
            nhacc.MaNhaCc = txtmanhacc.Text;
            DataTable dt = nhacc_bus.NhaCc_Delete(nhacc);
            MessageBox.Show(dt.Rows[0][0].ToString(), "Thông báo", MessageBoxButtons.OK);
        }

        public void NhaCc_ChapNhan()
        {
            if (txtmanhacc.Text == "")
            {
                MessageBox.Show("Nhập thiếu mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                NhaCungCapDTO nhacc = new NhaCungCapDTO();
                nhacc.MaNhaCc = txtmanhacc.Text;
                DataTable dt = nhacc_bus.NhaCc_SelectMa(nhacc);
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("Mã nhà cung cấp không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Đã chọn nhà cung cấp : "+dt.Rows[0][1].ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QLNguyenLieuNhap qlnhapnl = new QLNguyenLieuNhap(txtmanhacc.Text,TenDn,Quyen);
                    this.Hide();
                    qlnhapnl.ShowDialog();
                }
            }
        }

        public void clear()
        {
            txtmanhacc.Text = "";
            txtsdt.Text = "";
            txtdiachi.Text = "";
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            if(Quyen == "0")
            {
                btnsuasp.Visible = false;
                btnxoasp.Visible = false;
            }
            datanhacc.DataSource = nhacc_bus.NhaCc_Select();
            datanhacc.Columns[0].HeaderText = "Mã NCC";
            datanhacc.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datanhacc.Columns[0].Width = 180;
            datanhacc.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datanhacc.Columns[1].HeaderText = "Tên nhà cung cấp";
            datanhacc.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datanhacc.Columns[1].Width = 330;
            datanhacc.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datanhacc.Columns[2].HeaderText = "Số điện thoại";
            datanhacc.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datanhacc.Columns[2].Width = 200;
            datanhacc.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datanhacc.Columns[3].HeaderText = "Địa chỉ";
            datanhacc.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datanhacc.Columns[3].Width = 300;
            datanhacc.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datanhacc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void cbtennhacc_SelectedIndexChanged(object sender, EventArgs e)
        {
            NhaCc_SelectMa();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            NhaCc_Select();
            datanhacc.DataSource = nhacc_bus.NhaCc_Select();
            clear();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if(txtmanhacc.Text == "" || cbtennhacc.Text == "" || txtdiachi.Text == "" || txtsdt.Text == "")
            {
                MessageBox.Show("Nhập thiếu thông tin nhà cung cấp", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                NhaCc_Insert();
                btnload_Click(sender, e);
            }
        }

        private void btnxoasp_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Có chắc chắn muốn xóa thông tin nhà cung cấp", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(hoi == DialogResult.Yes)
            {
                if (txtmanhacc.Text == "")
                {
                    MessageBox.Show("Nhập thiếu mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    NhaCc_Delete();
                    btnload_Click(sender, e);
                }
            }
            
        }

        private void btnsuasp_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Có chắc chắn muốn sửa thông tin nhà cung cấp", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                if (txtmanhacc.Text == "" || cbtennhacc.Text == "" || txtdiachi.Text == "" || txtsdt.Text == "")
                {
                    MessageBox.Show("Nhập thiếu thông tin nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    NhaCc_Update();
                    btnload_Click(sender, e);
                }
            }
        }

        private void btnchapnhan_Click(object sender, EventArgs e)
        {
            NhaCc_ChapNhan();
        }


        private void nhapso(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tat(object sender, FormClosedEventArgs e)
        {
            QLNguyenLieuNhap qlnln = new QLNguyenLieuNhap("", TenDn, Quyen);
            this.Hide();
            qlnln.ShowDialog();
        }
    }
}
