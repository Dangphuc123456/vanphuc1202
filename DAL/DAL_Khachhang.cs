using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Khachhang : DBconnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getKhach()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from khach", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        void thucthisql(string sql)
        {
            _con.Open();
            cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }
        public int kiemtramatrung(string maKhach)
        {
            _con.Open();
            int i;
            string sql = "select count(*) from Khach where MaKhach='" + maKhach.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themKH(Khachhang kh)
        {
            string sql = "Insert into Khach values('" + kh.MaKhach + "',N'" + kh.TenKhach + "',N'" + kh.DiaChi + "','" + kh.DienThoai + "')";
            thucthisql(sql);
            return true;
        }
        public bool suaKH(Khachhang kh)
        {
            string sql = "Update Khach set TenKhach=N'" + kh.TenKhach + "',DiaChi=N'" + kh.DiaChi + "',DienThoai='" + kh.DienThoai + "'where MaKhach='" + kh.MaKhach + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaKH(string maKhach)
        {
            string sql = "Delete from Khach where MaKhach='" + maKhach + "'";
            thucthisql(sql);
            return true;
        }
    }
}
