using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Nhanvien:DBconnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //Hiển thị danh sách nhân viên
        public DataTable getNhanvien()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from NhanVien", _con);
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
        public int kiemtramatrung(string maNhanvien)
        {
            _con.Open();
            int i;
            string sql = "select count(*) from NhanVien where MaNhanVien='" + maNhanvien.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themNV(Nhanvien nv)
        {
            string ngay = string.Format("{0}/{1}/{2}", nv.NgaySinh.Year, nv.NgaySinh.Month, nv.NgaySinh.Day);
            string sql = "Insert into NhanVien values('" + nv.MaNhanVien + "','" + nv.TenNhanVien + "','" + nv.GioiTinh + "','" + nv.DiaChi + "','" + nv.DienThoai + "','" + ngay + "')";
            thucthisql(sql);
            return true;
        }
        public bool suaNV(Nhanvien nv)
        {
            string ngay = string.Format("{0}/{1}/{2}", nv.NgaySinh.Year, nv.NgaySinh.Month, nv.NgaySinh.Day);
            string sql = "Update NhanVien set TenNhanVien=N'" + nv.TenNhanVien + "',GioiTinh='" + nv.GioiTinh + "',DiaChi=N'" + nv.DiaChi + "',DienThoai='" + nv.DienThoai + "',NgaySinh='" + ngay + "' where MaNhanVien='" + nv.MaNhanVien + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaNV(string maNhanVien)
        {
            string sql = "Delete from NhanVien where MaNhanVien='" + maNhanVien + "'";
            thucthisql(sql);
            return true;
        }
    }
}

