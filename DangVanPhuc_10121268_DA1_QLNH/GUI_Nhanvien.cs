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
    public partial class GUI_Nhanvien : Form
    {
        BUS_Nhanvien busnv = new BUS_Nhanvien();
        public GUI_Nhanvien()
        {
            InitializeComponent();
        }
        private void GUI_Nhanvien_Load(object sender, EventArgs e)
        {
            dgvnv.DataSource = busnv.getNhanvien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtmanv.Text;
            string tenNhanvien = txttennv.Text;
            string gioiTinh = cbxgioitinh.Text;
            string diaChi = txtdiachi.Text;
            string dienThoai = txtdienthoai.Text;
            DateTime ngaySinh = DateTime.Parse(dtpngaysinh.Value.ToShortDateString());
            Nhanvien nv = new Nhanvien(maNhanVien, tenNhanvien, gioiTinh, diaChi, dienThoai, ngaySinh);
            if (busnv.kiemtramatrung(maNhanVien) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                if (string.IsNullOrEmpty(maNhanVien) || string.IsNullOrEmpty(tenNhanvien) || string.IsNullOrEmpty(gioiTinh) ||  string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(dienThoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
                if (busnv.themNV(nv) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    dgvnv.DataSource = busnv.getNhanvien();
                }
            }
            
        }

        private void dgvnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int hang = e.RowIndex;
            txtmanv.Text = dgvnv[0, hang].Value.ToString();
            txttennv.Text = dgvnv[1, hang].Value.ToString();
            cbxgioitinh.Text = dgvnv[2, hang].Value.ToString();
            txtdiachi.Text = dgvnv[3, hang].Value.ToString();
            txtdienthoai.Text = dgvnv[4, hang].Value.ToString();
            dtpngaysinh.Text = dgvnv[5, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtmanv.Text;
            string tenNhanvien = txttennv.Text;
            string gioiTinh = cbxgioitinh.Text;
            string diaChi = txtdiachi.Text;
            string dienThoai = txtdienthoai.Text;
            DateTime ngaySinh = DateTime.Parse(dtpngaysinh.Value.ToShortDateString());
            Nhanvien nv = new Nhanvien(maNhanVien, tenNhanvien, gioiTinh, diaChi, dienThoai, ngaySinh);

            if (busnv.suaNV(nv) == true)
            {
                MessageBox.Show("Sửa thành công");
                dgvnv.DataSource = busnv.getNhanvien();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtmanv.Text;
            if (busnv.xoaNV(maNhanVien) == true)
            {
                MessageBox.Show("Xóa thành công");
                dgvnv.DataSource = busnv.getNhanvien();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            GUI_Nhahang gUI_Nhahang = new GUI_Nhahang();
            gUI_Nhahang.AcceptButton = new System.Windows.Forms.Button();
            gUI_Nhahang.ShowDialog();
        }

        private void txtNV_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "MaNhanVien", "*" + txtNV.Text + "*");//khai báo biến
            (dgvnv.DataSource as DataTable).DefaultView.RowFilter = rowFilter;//điều kiện lọc được xác định bởi chuỗi rowFilter để hiển thị chỉ các hàng trong DataTable
        }
    }
}
