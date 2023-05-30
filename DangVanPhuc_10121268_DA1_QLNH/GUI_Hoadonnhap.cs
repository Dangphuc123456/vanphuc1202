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
    public partial class GUI_Hoadonnhap : Form
    {
        BUS_Hoadonnhap bushdn = new BUS_Hoadonnhap();
        public GUI_Hoadonnhap()
        {
            InitializeComponent();
        }

        private void GUI_Hoadonnhap_Load(object sender, EventArgs e)
        {
            dgvhdn.DataSource = bushdn.getHDNhap();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maHDNhap = txthdn.Text;
            string maNhanVien = cmbmnv.Text;
            string nhaCCID = txtncc.Text;
            DateTime ngayNhap = DateTime.Parse(dtpnn.Value.ToShortDateString());
            float tongTien = float.Parse(txtttien.Text);
            Hoadonnhap hdn = new Hoadonnhap(maHDNhap, maNhanVien, nhaCCID, ngayNhap, tongTien);
            if (bushdn.kiemtramatrung(maHDNhap) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {

                if (string.IsNullOrEmpty(maHDNhap) || string.IsNullOrEmpty(maNhanVien) || string.IsNullOrEmpty(nhaCCID))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
                else
                {
                    if (bushdn.themHDN(hdn) == true)
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvhdn.DataSource = bushdn.getHDNhap();
                    }
                }
            }
        }

        private void dgvhdn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txthdn.Text = dgvhdn[0, hang].Value.ToString();
            cmbmnv.Text = dgvhdn[1, hang].Value.ToString();
            txtncc.Text = dgvhdn[2, hang].Value.ToString();
            dtpnn.Text = dgvhdn[3, hang].Value.ToString();
            txtttien.Text = dgvhdn[4, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maHDNhap = txthdn.Text;
            string maNhanVien = cmbmnv.Text;
            string nhaCCID = txtncc.Text;
            DateTime ngayNhap = DateTime.Parse(dtpnn.Value.ToShortDateString());
            float tongTien = float.Parse(txtttien.Text);
            Hoadonnhap hdn = new Hoadonnhap(maHDNhap, maNhanVien, nhaCCID, ngayNhap, tongTien);

            if (bushdn.suaHDN(hdn) == true)
            {
                MessageBox.Show("Sửa thành công");
                dgvhdn.DataSource = bushdn.getHDNhap();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHDNhap = txthdn.Text;
            if (bushdn.xoaHDN(maHDNhap) == true)
            {
                MessageBox.Show("Xóa thành công");
                dgvhdn.DataSource = bushdn.getHDNhap();
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
            string rowFilter = string.Format("{0} like '{1}'", "MaHDNhap", "*" + txtTKHDB.Text + "*");//khai báo biến
            (dgvhdn.DataSource as DataTable).DefaultView.RowFilter = rowFilter;//điều kiện lọc được xác định bởi chuỗi rowFilter để hiển thị chỉ các hàng trong DataTable
        }

        private void btnCTHDN_Click(object sender, EventArgs e)
        {
            GUI_Chitiethoadonnhap gUI_Chitiethoadonnhap=new GUI_Chitiethoadonnhap();
            gUI_Chitiethoadonnhap.AcceptButton = new System.Windows.Forms.Button();
            gUI_Chitiethoadonnhap.Show();
        }
    }
}
