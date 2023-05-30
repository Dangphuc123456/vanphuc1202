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
    public partial class GUI_Nhahang : Form
    {
        public GUI_Nhahang()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            GUI_Monan gUI_Monan = new GUI_Monan();
            gUI_Monan.AcceptButton=new System.Windows.Forms.Button();
            gUI_Monan.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            GUI_Nguyenlieu gUI_Nguyenlieu = new GUI_Nguyenlieu();
            gUI_Nguyenlieu.AcceptButton=new System.Windows.Forms.Button();
            gUI_Nguyenlieu.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            GUI_Khachhang gUI_Khachhang = new GUI_Khachhang();
            gUI_Khachhang.AcceptButton=new System.Windows.Forms.Button();
            gUI_Khachhang.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            GUI_Nhanvien gUI_Nhanvien = new GUI_Nhanvien();
            gUI_Nhanvien.AcceptButton=new System.Windows.Forms.Button();
            gUI_Nhanvien.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            GUI_Hoadonnhap gUI_Hoadonnhap = new GUI_Hoadonnhap();
            gUI_Hoadonnhap.AcceptButton=new System.Windows.Forms.Button();
            gUI_Hoadonnhap.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            GUI_Chitiethoadonnhap gUI_Chitiethoadonnhap = new GUI_Chitiethoadonnhap();
            gUI_Chitiethoadonnhap.AcceptButton =new System.Windows.Forms.Button();
            gUI_Chitiethoadonnhap.Show();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            GUI_Hoadonban gUI_Hoadonban = new GUI_Hoadonban();
            gUI_Hoadonban.AcceptButton=new System.Windows.Forms.Button();
            gUI_Hoadonban.Show();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            GUI_Chitiethoadonban gUI_Chitiethoadonban = new GUI_Chitiethoadonban();
            gUI_Chitiethoadonban.AcceptButton =new System.Windows.Forms.Button();
            gUI_Chitiethoadonban.Show();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            GUI_Nhacungcap gUI_Nhacungcap = new GUI_Nhacungcap();
            gUI_Nhacungcap.AcceptButton =new System.Windows.Forms.Button();
            gUI_Nhacungcap.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.AcceptButton =new System.Windows.Forms.Button();
            form1.ShowDialog();        
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            GUI_Thongkehoadonban gUI_Thongkehoadonban = new GUI_Thongkehoadonban();
            gUI_Thongkehoadonban.AcceptButton = new System.Windows.Forms.Button();
            gUI_Thongkehoadonban.Show();
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            GUI_Thongkehoadonnhap gUI_Thongkehoadonnhap = new GUI_Thongkehoadonnhap();
            gUI_Thongkehoadonnhap.AcceptButton = new System.Windows.Forms.Button();
            gUI_Thongkehoadonnhap.Show();
        }
    }
}
