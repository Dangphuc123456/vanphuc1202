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
    public class DAL_Monan : DBconnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //hiển thị danh sách món ăn ra ngoài màn hình
        public DataTable getMonan()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from Monan", _con);
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
        public int kiemtramatrung(string mamonan)
        {
            _con.Open();
            int i;
            string sql = "select count(*) from Monan where Mamonan='" + mamonan.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themMA(Monan ma)
        {
            string sql = "Insert into Monan values('" + ma.Mamonan + "','" + ma.Tenmonan + "','" + ma.Loaimonan + "')";
            thucthisql(sql);
            return true;
        }
        public bool suaMA(Monan ma)
        {
            string sql = "Update Monan set Tenmonan=N'" + ma.Tenmonan + "',Loaimonan= '" + ma.Loaimonan + "'  where Mamonan='" + ma.Mamonan + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaMA(string mamonan)
        {
            string sql = "Delete from Monan where Mamonan='" + mamonan + "'";
            thucthisql(sql);
            return true;
        }
    }
}
