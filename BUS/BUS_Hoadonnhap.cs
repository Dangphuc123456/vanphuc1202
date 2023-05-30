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
    public class BUS_Hoadonnhap
    {
        DAL_Hoadonnhap dalhdn = new DAL_Hoadonnhap();
        public DataTable getHDNhap()
        {
            return dalhdn.getHDNhap();
        }
        public int kiemtramatrung(string maHDNhap)
        {
            return dalhdn.kiemtramatrung(maHDNhap);
        }
        public bool themHDN(Hoadonnhap hdn)
        {
            return dalhdn.themHDN(hdn);
        }
        public bool suaHDN(Hoadonnhap hdn)
        {
            return dalhdn.suaHDN(hdn);
        }
        public bool xoaHDN(string maHDNhap)
        {
            return dalhdn.xoaHDN(maHDNhap);
        }
    }
}
