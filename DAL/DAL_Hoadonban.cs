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
    public class DAL_Hoadonban : DBconnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //Hiểm thị thông tin ra ngoài màn hình
        public DataTable getHDBan()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from HDBan", _con);
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
        public int kiemtramatrung(string maHDBan)
        {
            _con.Open();
            int i;
            string sql = "select count(*) from HDBan  where MaHDBan='" + maHDBan.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themHDB(Hoadonban hdb)
        {
            string ngay = string.Format("{0}/{1}/{2}", hdb.NgayBan.Year, hdb.NgayBan.Month, hdb.NgayBan.Day);
            string sql = "Insert into  HDBan values('" + hdb.MaHDBan + "','" + hdb.MaNhanVien + "','" + ngay + "','" + hdb.MaKhach + "','" + hdb.TongTien + "')";
            thucthisql(sql);
            return true;
        }
        public bool suaHDB(Hoadonban hdb)
        {
            string ngay = string.Format("{0}/{1}/{2}", hdb.NgayBan.Year, hdb.NgayBan.Month, hdb.NgayBan.Day);
            string sql = "UPDATE HDBan SET MaNhanVien = N'" + hdb.MaNhanVien + "', NgayBan = '" + ngay + "', MaKhach = '" + hdb.MaKhach + "', TongTien = " + hdb.TongTien + " WHERE MaHDBan = '" + hdb.MaHDBan + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaHDB(string maHDBan)
        {
            string sql = "Delete from HDBan where MaHDBan='" + maHDBan + "'";
            thucthisql(sql);
            return true;
        }
    }
}
