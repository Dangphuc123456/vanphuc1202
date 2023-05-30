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
    public partial class GUI_Chitiethoadonban : Form
    {
        BUS_Chitiethoadonban buscthdb = new BUS_Chitiethoadonban();
        public GUI_Chitiethoadonban()
        {
            InitializeComponent();
        }

        private void GUI_Chitiethoadonban_Load(object sender, EventArgs e)
        {
            dgvCTB.DataSource = buscthdb.getChiTietHDBan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maCTBan = txtMCTB.Text;
            string maHDBan = txtMDB.Text;
            string mamonan = txtMMA.Text;
            int soLuong = int.Parse(txtSL.Text);
            float donGia = float.Parse(txtDG.Text);
            float giamGia = float.Parse(txtGG.Text);
            float thanhTien = float.Parse(txtTT.Text);
            Chitiethoadonban ctdhb = new Chitiethoadonban(maCTBan, maHDBan, mamonan, soLuong, donGia, giamGia, thanhTien);
            if (buscthdb.kiemtramatrung(maCTBan) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                if (string.IsNullOrEmpty(maCTBan) || string.IsNullOrEmpty(maHDBan) || string.IsNullOrEmpty(mamonan))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
                else
                {
                    if (buscthdb.themCTHDB(ctdhb) == true)
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvCTB.DataSource = buscthdb.getChiTietHDBan();
                    }
                }
            }
        }

        private void dgvCTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMCTB.Text = dgvCTB[0, hang].Value.ToString();
            txtMDB.Text = dgvCTB[1, hang].Value.ToString();
            txtMMA.Text = dgvCTB[2, hang].Value.ToString();
            txtSL.Text = dgvCTB[3, hang].Value.ToString();
            txtDG.Text = dgvCTB[4, hang].Value.ToString();
            txtGG.Text = dgvCTB[5, hang].Value.ToString();
            txtTT.Text = dgvCTB[6, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maCTBan = txtMCTB.Text;
            string maMDBBan = txtMDB.Text;
            string mamonan = txtMMA.Text;
            int soLuong = int.Parse(txtSL.Text);
            float donGia = float.Parse(txtDG.Text);
            float giamGia = float.Parse(txtGG.Text);
            float thanhTien = float.Parse(txtTT.Text);
            Chitiethoadonban ctdhb = new Chitiethoadonban(maCTBan, maMDBBan, mamonan, soLuong, donGia, giamGia, thanhTien);
            if (buscthdb.suaCTHDB(ctdhb) == true)
            {
                MessageBox.Show("Sửa thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maCTBan = txtMCTB.Text;
            if (buscthdb.xoaCTHDB(maCTBan) == true)
            {
                MessageBox.Show("Xóa thành công ");
                dgvCTB.DataSource = buscthdb.getChiTietHDBan();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            GUI_Nhahang gUI_Nhahang = new GUI_Nhahang();
            gUI_Nhahang.AcceptButton = new System.Windows.Forms.Button();
            gUI_Nhahang.ShowDialog();
        }

        private void txtCTB_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "MaCTBan", "*" + txtCTB.Text + "*");
            (dgvCTB.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
    }
}
