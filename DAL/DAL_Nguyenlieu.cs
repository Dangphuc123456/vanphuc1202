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
    public class DAL_Nguyenlieu : DBconnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //Hiển thị danh sách nnguyên liệu
        public DataTable getNguyenlieu()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from Nguyenlieu", _con);
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
        public int kiemtramatrung(string maNguyenLieu)
        {
            _con.Open();
            int i;
            string sql = "select count(*) from Nguyenlieu  where MaNguyenLieu='" + maNguyenLieu.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themNL(Nguyenlieu nl)
        {
            string sql = "Insert into Nguyenlieu values('" + nl.MaNguyenLieu + "','" + nl.TenNguyenLieu + "','" + nl.SoLuong + "','" + nl.DonGiaNhap + "','" + nl.GhiChu + "')";
            thucthisql(sql);
            return true;
        }
        public bool suaNL(Nguyenlieu nl)
        {
            string sql = "Update Nguyenlieu set TenNguyenLieu=N'" + nl.TenNguyenLieu + "',SoLuong= '" + nl.SoLuong + "' ,DonGiaNhap='"+ nl.DonGiaNhap + "',GhiChu='"+nl.GhiChu+ "' where MaNguyenLieu='" + nl.MaNguyenLieu + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaNL(string maNguyenLieu)
        {
            string sql = "Delete from Nguyenlieu where MaNguyenlieu='" + maNguyenLieu + "'";
            thucthisql(sql);
            return true;
        }
    }
}
