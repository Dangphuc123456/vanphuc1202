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
using System.Data.SqlClient;

namespace DangVanPhuc_10121268_DA1_QLNH
{
    public partial class GUI_Chitiethoadonnhap : Form
    {
        BUS_Chitiethoadonnhap buscthdn = new BUS_Chitiethoadonnhap();
        public GUI_Chitiethoadonnhap()
        {
            InitializeComponent();
        }

        private void GUI_Chitiethoadonnhap_Load(object sender, EventArgs e)
        {
            dgvCTN.DataSource = buscthdn.getChiTietHDNhap();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maCTNhap = txtMCTN.Text;
            string maHDNhap = txtMDN.Text;
            string maNguyenlieu = cmbMNL.Text;
            int soLuong = int.Parse(txtSL.Text);
            float donGia = float.Parse(txtDG.Text);
            float thanhTien = float.Parse(txtTT.Text);
            Chitiethoadonnhap ctdhn = new Chitiethoadonnhap(maCTNhap, maHDNhap, maNguyenlieu, soLuong, donGia, thanhTien);
            if (buscthdn.kiemtramatrung(maHDNhap) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                if (string.IsNullOrEmpty(maCTNhap) || string.IsNullOrEmpty(maHDNhap) || string.IsNullOrEmpty(maNguyenlieu))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
                else
                {
                    if (buscthdn.themCTHDN(ctdhn) == true)
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvCTN.DataSource = buscthdn.getChiTietHDNhap();
                    }
                }
            }
        }

        private void dgvCTN_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int hang = e.RowIndex;
            txtMCTN.Text = dgvCTN[0, hang].Value.ToString();
            txtMDN.Text = dgvCTN[1, hang].Value.ToString();
            cmbMNL.Text = dgvCTN[2, hang].Value.ToString();
            txtSL.Text = dgvCTN[3, hang].Value.ToString();
            txtDG.Text = dgvCTN[4, hang].Value.ToString();
            txtTT.Text = dgvCTN[5, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maCTNhap = txtMCTN.Text;
            string maHDNhap = txtMDN.Text;
            string maNguyenlieu = cmbMNL.Text;
            int soLuong = int.Parse(txtSL.Text);
            float donGia = float.Parse(txtDG.Text);
            float thanhTien = float.Parse(txtTT.Text);
            Chitiethoadonnhap ctdhn = new Chitiethoadonnhap(maCTNhap, maHDNhap, maNguyenlieu, soLuong, donGia, thanhTien);
            if (buscthdn.suaCTHDN(ctdhn) == true)
            {
                MessageBox.Show("Sửa thành công");
                dgvCTN.DataSource = buscthdn.getChiTietHDNhap();
            }
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maCTNhap = txtMCTN.Text;
            if (buscthdn.xoaCTHDN(maCTNhap) == true)
            {
                MessageBox.Show("Xóa thành công ");
                dgvCTN.DataSource = buscthdn.getChiTietHDNhap();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            GUI_Nhahang gUI_Nhahang = new GUI_Nhahang();
            gUI_Nhahang.AcceptButton = new System.Windows.Forms.Button();
            gUI_Nhahang.ShowDialog();
        }

        private void txtCTN_TextChanged(object sender, EventArgs e)
        {
            //sử dụng thuộc tính RowFilter để tìm kiếm theo tên "Name"
            string rowFilter = string.Format("{0} like '{1}'", "MaCTNhap", "*" + txtCTN.Text + "*");
            (dgvCTN.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
    }
}
