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
    public partial class GUI_Nhacungcap : Form
    {
        BUS_Nhacungcap busncc = new BUS_Nhacungcap();
        public GUI_Nhacungcap()
        {
            InitializeComponent();
        }
        private void GUI_Nhacungcap_Load(object sender, EventArgs e)
        {
            dgvncc.DataSource = busncc.getNhaCC();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            string nhaCCID = txtncc.Text;
            string tenNCC = txtncc.Text;
            string diachiNCC = txtdc.Text;
            string sdtNCC = txtsdt.Text;
            Nhacungcap ncc = new Nhacungcap(nhaCCID, tenNCC, diachiNCC, sdtNCC);
            if (busncc.kiemtramatrung(nhaCCID) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                if (string.IsNullOrEmpty(nhaCCID) || string.IsNullOrEmpty(tenNCC) || string.IsNullOrEmpty(diachiNCC) || string.IsNullOrEmpty(sdtNCC))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
                else
                {

                    if (busncc.themNCC(ncc) == true)
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvncc.DataSource = busncc.getNhaCC();

                    }
                }    
            }
            
        }

        private void dgvncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtncc.Text = dgvncc[0, hang].Value.ToString();
            txttncc.Text = dgvncc[1, hang].Value.ToString();
            txtdc.Text = dgvncc[2, hang].Value.ToString();
            txtsdt.Text = dgvncc[3, hang].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

            string nhaCCID = txtncc.Text;
            string tenNCC = txtncc.Text;
            string diachiNCC = txtdc.Text;
            string sdtNCC = txtsdt.Text;
            Nhacungcap ncc = new Nhacungcap(nhaCCID, tenNCC, diachiNCC, sdtNCC);
            if (busncc.suaNCC(ncc) == true)
            {
                MessageBox.Show("Sửa thành công");
                dgvncc.DataSource = busncc.getNhaCC();

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string nhaCCID = txtncc.Text;
            if (busncc.xoaNCC(nhaCCID) == true)
            {
                MessageBox.Show("Xóa thành công");
                dgvncc.DataSource = busncc.getNhaCC();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            GUI_Nhahang gUI_Nhahang = new GUI_Nhahang();
            gUI_Nhahang.AcceptButton = new System.Windows.Forms.Button();
            gUI_Nhahang.ShowDialog();
        }

        private void txtTKNCC_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "NhaCCID", "*" + txtTKNCC.Text + "*");//khai báo biến
            (dgvncc.DataSource as DataTable).DefaultView.RowFilter = rowFilter;//điều kiện lọc được xác định bởi chuỗi rowFilter để hiển thị chỉ các hàng trong DataTable
        }

        
    }
}
