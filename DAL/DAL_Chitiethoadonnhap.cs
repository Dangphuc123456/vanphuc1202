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
    public class DAL_Chitiethoadonnhap : DBconnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //Hiển thị dữ liệu ra ngoài màn hình
        public DataTable getChiTietHDNhap()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from ChiTietHDNhap", _con);
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
        public int kiemtramatrung(string maCTNhap)
        {
            _con.Open();
            int i;
            string sql = "select count(*) from  ChiTietHDNhap  where MaHDNhap ='" + maCTNhap.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themCTHDN(Chitiethoadonnhap cthdn)
        {
            string sql = "Insert into ChiTietHDNhap values('" + cthdn.MaCTNhap + "','" + cthdn.MaHDNhap + "','" + cthdn.MaNguyenlieu + "','" + cthdn.SoLuong + "','" + cthdn.DonGia + "','" + cthdn.ThanhTien + "')";
            thucthisql(sql);
            return true;
        }
        public bool suaCTHDN(Chitiethoadonnhap cthdn)
        {
            string sql = "Update ChiTietHDNhap set   MaHDNhap='" + cthdn.MaHDNhap + "', MaNguyenlieu=N'" + cthdn.MaNguyenlieu + "',SoLuong='" + cthdn.SoLuong + "',DonGia='" + cthdn.DonGia + "',ThanhTien='" + cthdn.ThanhTien + "'where MaCTNhap=N'" + cthdn.MaCTNhap + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaCTHDN(string maCTNhap)
        {
            string sql = "Delete from  ChiTietHDNhap where  MaCTNhap=N'" + maCTNhap + "' ";
            thucthisql(sql);
            return true;
        }
    }
}
