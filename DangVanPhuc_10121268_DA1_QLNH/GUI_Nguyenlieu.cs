using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangVanPhuc_10121268_DA1_QLNH
{
    public partial class GUI_Nguyenlieu : Form
    {
        BUS_Nguyenlieu busnl = new BUS_Nguyenlieu();
        public GUI_Nguyenlieu()
        {
            InitializeComponent();
        }

        private void GUI_Nguyenlieu_Load(object sender, EventArgs e)
        {
            dgvnl.DataSource = busnl.getNguyenlieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNguyenLieu = txtmnl.Text;
            string tenNguyenLieu = txttnl.Text;
            float soLuong = float.Parse(txtsl.Text);
            float donGiaNhap = float.Parse(txtdgn.Text);
            string ghiChu = txtgc.Text;
            Nguyenlieu nl = new Nguyenlieu(maNguyenLieu, tenNguyenLieu, soLuong, donGiaNhap, ghiChu);
            if (busnl.kiemtramatrung(maNguyenLieu) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                
               
                    if (busnl.themNL(nl) == true)
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvnl.DataSource = busnl.getNguyenlieu();
                    }
               
            }
        }

        private void dgvnl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtmnl.Text = dgvnl[0, hang].Value.ToString();
            txttnl.Text = dgvnl[1, hang].Value.ToString();
            txtsl.Text = dgvnl[2, hang].Value.ToString();
            txtdgn.Text = dgvnl[3, hang].Value.ToString();
            txtgc.Text = dgvnl[4, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNguyenLieu = txtmnl.Text;
            string tenNguyenLieu = txttnl.Text;
            float soLuong = float.Parse(txtsl.Text);
            float donGiaNhap = float.Parse(txtdgn.Text);
            string ghiChu = txtgc.Text;
            Nguyenlieu nl = new Nguyenlieu(maNguyenLieu, tenNguyenLieu, soLuong, donGiaNhap, ghiChu);
            if (busnl.suaNL(nl) == true)
            {
                MessageBox.Show("Sửa thành công");
                dgvnl.DataSource = busnl.getNguyenlieu();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNguyenLieu = txtmnl.Text;
            if (busnl.xoaNL(maNguyenLieu) == true)
            {
                MessageBox.Show("Xóa thành công");
                dgvnl.DataSource = busnl.getNguyenlieu();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            GUI_Nhahang gUI_Nhahang = new GUI_Nhahang();
            gUI_Nhahang.AcceptButton = new System.Windows.Forms.Button();
            gUI_Nhahang.ShowDialog();
        }

        private void txtNL_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "MaNguyenLieu", "*" + txtNL.Text + "*");
            (dgvnl.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
    }
}
