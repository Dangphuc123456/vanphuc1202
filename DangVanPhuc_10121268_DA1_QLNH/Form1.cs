using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangVanPhuc_10121268_DA1_QLNH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            SqlConnection _con = new SqlConnection(@"Data Source=DESKTOP-10EUU23\SQLEXPRESS;Initial Catalog=DVP_10121268_DA1;Integrated Security=True;Pooling=False");
            _con.Open();
            string tk = txtTK.Text;
            string mk = txtMK.Text;
            string cv = cmbCV.Text;
            string sql = "SELECT * FROM DangNhap WHERE TaiKhoan = '" + tk + "' AND MatKhau = '" + mk + "' AND Chucvu = '" + cv + "'";
            SqlCommand cmd = new SqlCommand(sql, _con);
            SqlDataReader dt = cmd.ExecuteReader();

            if (dt.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công");
                GUI_Nhahang gUI_Nhahang = new GUI_Nhahang();
                gUI_Nhahang.AcceptButton = new System.Windows.Forms.Button();
                gUI_Nhahang.ShowDialog();

            }
            else
            {
                if (string.IsNullOrEmpty(tk) || string.IsNullOrEmpty(mk) || string.IsNullOrEmpty(cv))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
                else
                {
                    MessageBox.Show(" Tài khoản hoặc mật khẩu không đúng");
                }    
            }

        }
        private void btnT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
