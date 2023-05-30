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
    public partial class GUI_Khachhang : Form
    {
        BUS_Khachhang buskh = new BUS_Khachhang();
        public GUI_Khachhang()
        {
            InitializeComponent();
        }

        private void GUI_Khachhang_Load(object sender, EventArgs e)
        {
            dgvkh.DataSource = buskh.getKhach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKhach = txtmkh.Text;
            string tenKhach = txttkh.Text;
            string diaChi = txtdc.Text;
            string dienThoai = txtdt.Text;
            Khachhang kh = new Khachhang(maKhach, maKhach, diaChi, dienThoai);
            if (buskh.kiemtramatrung(maKhach) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                if (string.IsNullOrEmpty(maKhach) || string.IsNullOrEmpty(maKhach) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(dienThoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
                else
                {
                    if (buskh.themKH(kh) == true)
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvkh.DataSource = buskh.getKhach();
                    }
                }
            }
        }

        private void dgvkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtmkh.Text = dgvkh[0, hang].Value.ToString();
            txttkh.Text = dgvkh[1, hang].Value.ToString();
            txtdc.Text = dgvkh[2, hang].Value.ToString();
            txtdt.Text = dgvkh[3, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKhach = txtmkh.Text;
            string tenKhach = txttkh.Text;
            string diaChi = txtdc.Text;
            string dienThoai = txtdt.Text;
            Khachhang kh = new Khachhang(maKhach, tenKhach, diaChi, dienThoai);

            if (buskh.suaKH(kh) == true)
            {
                MessageBox.Show("Sửa thành công");
                dgvkh.DataSource = buskh.getKhach();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKhach = txtmkh.Text;
            if (buskh.xoaKH(maKhach) == true)
            {
                MessageBox.Show("Xóa thành công");
                dgvkh.DataSource = buskh.getKhach();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            GUI_Nhahang gUI_Nhahang = new GUI_Nhahang();
            gUI_Nhahang.AcceptButton= new System.Windows.Forms.Button();
            gUI_Nhahang.Show(this);
        }

        private void txtKH_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "MaKhach", "*" + txtKH.Text + "*");//khai báo biến
            (dgvkh.DataSource as DataTable).DefaultView.RowFilter = rowFilter;//điều kiện lọc được xác định bởi chuỗi rowFilter để hiển thị chỉ các hàng trong DataTable
        }
    }
}
