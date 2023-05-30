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
    public class BUS_Chitiethoadonnhap
    {
        DAL_Chitiethoadonnhap dalctdhn = new DAL_Chitiethoadonnhap();
        public DataTable getChiTietHDNhap()
        {
            return dalctdhn.getChiTietHDNhap();
        }
        public int kiemtramatrung(string maCTNhap)
        {
            return dalctdhn.kiemtramatrung(maCTNhap);
        }
        public bool themCTHDN(Chitiethoadonnhap cthdn)
        {
            return dalctdhn.themCTHDN(cthdn);
        }
        public bool suaCTHDN(Chitiethoadonnhap cthdn)
        {
            return dalctdhn.suaCTHDN(cthdn);
        }
        public bool xoaCTHDN(string maCTNhap)
        {
            return dalctdhn.xoaCTHDN(maCTNhap);
        }
    }
}
