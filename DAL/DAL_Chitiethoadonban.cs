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
    public class DAL_Chitiethoadonban : DBconnect
    {

        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getChiTietHDBan()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from ChiTietHDBan", _con);
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
        public int kiemtramatrung(string maCTBan)
        {
            _con.Open();
            int i;
            string sql = "select count(*) from ChiTietHDBan   where MaCTBan ='" + maCTBan.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themCTHDB(Chitiethoadonban cthdb)
        {
            string sql = "Insert into ChiTietHDBan values('" + cthdb.MaCTBan + "','" + cthdb.MaHDBan + "','" + cthdb.Mamonan + "','" + cthdb.SoLuong + "','" + cthdb.DonGia + "','" + cthdb.GiamGia + "','" + cthdb.ThanhTien + "')";
            thucthisql(sql);
            return true;
        }
        public bool suaCTHDB(Chitiethoadonban cthdb)
        {
            string value = "0.1"; // giá trị chuỗi
            float floatValue = Convert.ToSingle(value); // chuyển đổi sang kiểu số
            string sql = "UPDATE ChiTietHDBan SET    MaHDBan=N'" + cthdb.MaHDBan + "', Mamonan=N'" + cthdb.Mamonan + "', SoLuong='" + cthdb.SoLuong + "', DonGia='" + cthdb.DonGia + "', GiamGia='" + cthdb.GiamGia + "', ThanhTien='" + cthdb.ThanhTien + "' WHERE MaCTBan =N'" + cthdb.MaCTBan + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaCTHDB(string maCTBan)
        {
            string sql = "Delete from ChiTietHDBan where  MaCTBan=N'" + maCTBan + "' ";
            thucthisql(sql);
            return true;
        }
    }
}

