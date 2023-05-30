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
    public partial class GUI_Hoadonban : Form
    {
        BUS_Hoadonban bushdb = new BUS_Hoadonban();
        public GUI_Hoadonban()
        {
            InitializeComponent();
        }

        private void GUI_Hoadonban_Load(object sender, EventArgs e)
        {
            dgvhdb.DataSource = bushdb.getHDBan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maHDBan = txtmhd.Text;
            string maNhanVien = cmbmnv.Text;
            DateTime ngayBan = DateTime.Parse(dtpnb.Value.ToShortDateString());
            string maKhach = txtmkh.Text;
            float tongTien = float.Parse(txttongt.Text);
            Hoadonban hdb = new Hoadonban(maHDBan, maNhanVien, ngayBan, maKhach, tongTien);
            if (bushdb.kiemtramatrung(maHDBan) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                if (string.IsNullOrEmpty(maHDBan) || string.IsNullOrEmpty(maNhanVien) || string.IsNullOrEmpty(maKhach))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
                else
                {
                    if (bushdb.themHDB(hdb) == true)
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvhdb.DataSource = bushdb.getHDBan();
                    }
                }
            }
        }

        private void dgvhdb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtmhd.Text = dgvhdb[0, hang].Value.ToString();
            cmbmnv.Text = dgvhdb[1, hang].Value.ToString();
            dtpnb.Text = dgvhdb[2, hang].Value.ToString();
            txtmkh.Text = dgvhdb[3, hang].Value.ToString();
            txttongt.Text = dgvhdb[4, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maHDBan = txtmhd.Text;
            string maNhanVien = cmbmnv.Text;
            DateTime ngayBan = DateTime.Parse(dtpnb.Value.ToShortDateString());
            string maKhach = txtmkh.Text;
            float tongTien = float.Parse(txttongt.Text);
            Hoadonban hdb = new Hoadonban(maHDBan, maNhanVien, ngayBan, maKhach, tongTien);
            if (bushdb.suaHDB(hdb) == true)
            {
                MessageBox.Show("Sửa thành công");
                dgvhdb.DataSource = bushdb.getHDBan();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHDBan = txtmhd.Text;
            if (bushdb.xoaHDB(maHDBan) == true)
            {
                MessageBox.Show("Xóa thành công");
                dgvhdb.DataSource = bushdb.getHDBan();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            GUI_Nhahang gUI_Nhahang = new GUI_Nhahang();
            gUI_Nhahang.AcceptButton = new System.Windows.Forms.Button();
            gUI_Nhahang.ShowDialog();
        }

        private void txtTKHDB_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "MaHDBan", "*" + txtTKHDB.Text + "*");
            (dgvhdb.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI_Chitiethoadonban gUI_Chitiethoadonban =new GUI_Chitiethoadonban();
            gUI_Chitiethoadonban.AcceptButton = new System.Windows.Forms.Button();
            gUI_Chitiethoadonban.Show();
        }
    }
}
