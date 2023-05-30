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
    public partial class GUI_Monan : Form
    {
        BUS_Monan busma = new BUS_Monan();
        public GUI_Monan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mamonan = txtmma.Text;
            string tenmonan = txttma.Text;
            string loaimonan = txtlma.Text;
            Monan ma = new Monan(mamonan, tenmonan, loaimonan);
            if (busma.kiemtramatrung(mamonan) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                if (string.IsNullOrEmpty(mamonan) || string.IsNullOrEmpty(tenmonan) || string.IsNullOrEmpty(loaimonan))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
                else
                {
                    if (busma.themMA(ma) == true)
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvma.DataSource = busma.getMonan();
                    }
                }
            }
        }

        private void dgvma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtmma.Text = dgvma[0, hang].Value.ToString();
            txttma.Text = dgvma[1, hang].Value.ToString();
            txtlma.Text = dgvma[2, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mamonan = txtmma.Text;
            string tenmonan = txttma.Text;
            string loaimonan = txtlma.Text;
            Monan ma = new Monan(mamonan, tenmonan, loaimonan);

            if (busma.suaMA(ma) == true)
            {
                MessageBox.Show("Sửa thành công");
                dgvma.DataSource = busma.getMonan();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mamonan = txtmma.Text;
            if (busma.xoaMA(mamonan) == true)
            {
                MessageBox.Show("Xóa thành công");
                dgvma.DataSource = busma.getMonan();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            GUI_Nhahang gUI_Nhahang = new GUI_Nhahang();
            gUI_Nhahang.AcceptButton = new System.Windows.Forms.Button();
            gUI_Nhahang.ShowDialog();
        }

        private void txtMA_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "Mamonan", "*" + txtMA.Text + "*");//khai báo biến
            (dgvma.DataSource as DataTable).DefaultView.RowFilter = rowFilter;//điều kiện lọc được xác định bởi chuỗi rowFilter để hiển thị chỉ các hàng trong DataTable
        }

        private void GUI_Monan_Load(object sender, EventArgs e)
        {
            dgvma.DataSource = busma.getMonan();
        }
    }
}
