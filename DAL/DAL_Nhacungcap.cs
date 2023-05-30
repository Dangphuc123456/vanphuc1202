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
    public class DAL_Nhacungcap : DBconnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //Hiển thị danh sách nhà cung cấp
        public DataTable getNhaCC()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from NhaCC", _con);
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
        public int kiemtramatrung(string nhaCCID)
        {
            _con.Open();
            int i;
            string sql = "select count(*) from NhaCC where NhaCCID='" + nhaCCID.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themNCC(Nhacungcap ncc)
        {
            string sql = "Insert into NhaCC values('" + ncc.NhaCCID + "','" + ncc.TenNCC + "','" + ncc.DiachiNCC + "','" + ncc.SdtNCC + "')";
            thucthisql(sql);
            return true;
        }
        public bool suaNCC(Nhacungcap ncc)
        {
            string sql = "Update NhaCC set TenNCC=N'" + ncc.TenNCC + "',DiachiNCC='N" + ncc.DiachiNCC + "',SdtNCC='" + ncc.SdtNCC + "'  where NhaCCID='" + ncc.NhaCCID + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaNCC(string nhaCCID)
        {
            string sql = "Delete from NhaCC where NhaCCID='" + nhaCCID + "'";
            thucthisql(sql);
            return true;
        }
    }
}

