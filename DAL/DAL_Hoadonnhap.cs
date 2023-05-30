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
    public class DAL_Hoadonnhap : DBconnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //Hiển thị thông tin hóa đơn nhập ra ngoài màn hình
        public DataTable getHDNhap()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from HDNhap", _con);
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
        public int kiemtramatrung(string maHDNhap)
        {
            _con.Open();
            int i;
            string sql = "select count(*) from HDNhap  where MaHDNhap='" + maHDNhap.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themHDN(Hoadonnhap hdn)
        {
            string ngay = string.Format("{0}/{1}/{2}", hdn.NgayNhap.Year, hdn.NgayNhap.Month, hdn.NgayNhap.Day);
            string sql = "Insert into  HDNhap values('" + hdn.MaHDNhap + "','" + hdn.MaNhanVien + "','" + hdn.NhaCCID + "','" + ngay + "','" + hdn.TongTien + "')";
            thucthisql(sql);
            return true;
        }
        public bool suaHDN(Hoadonnhap hdn)
        {
            string ngay = string.Format("{0}/{1}/{2}", hdn.NgayNhap.Year, hdn.NgayNhap.Month, hdn.NgayNhap.Day);
            string sql = "UPDATE HDNhap SET MaNhanVien = N'" + hdn.MaNhanVien + "', NhaCCID = '" + hdn.NhaCCID + "', NgayNhap = '" + ngay + "', TongTien = '" + hdn.TongTien + "' WHERE MaHDNhap = '" + hdn.MaHDNhap + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaHDN(string maHDNhap)
        {
            string sql = "Delete from  HDNhap where MaHDNhap='" + maHDNhap + "'";
            thucthisql(sql);
            return true;
        }
    }
}
