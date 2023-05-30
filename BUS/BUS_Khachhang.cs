using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_Khachhang
    {
        DAL_Khachhang dalkh = new DAL_Khachhang();
        public DataTable getKhach()
        {
            return dalkh.getKhach();
        }
        public int kiemtramatrung(string maKhach)
        {
            return dalkh.kiemtramatrung(maKhach);
        }
        public bool themKH(Khachhang kh)
        {
            return dalkh.themKH(kh);
        }
        public bool suaKH(Khachhang kh)
        {
            return dalkh.suaKH(kh);
        }
        public bool xoaKH(string maKhach)
        {
            return dalkh.xoaKH(maKhach);
        }
    }
}
