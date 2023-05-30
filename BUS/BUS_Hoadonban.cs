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
    public class BUS_Hoadonban
    {
        DAL_Hoadonban dalhdb = new DAL_Hoadonban();
        public DataTable getHDBan()
        {
            return dalhdb.getHDBan();
        }
        public int kiemtramatrung(string maHDBan)
        {
            return dalhdb.kiemtramatrung(maHDBan);
        }
        public bool themHDB(Hoadonban hdb)
        {
            return dalhdb.themHDB(hdb);
        }
        public bool suaHDB(Hoadonban hdb)
        {
            return dalhdb.suaHDB(hdb);
        }
        public bool xoaHDB(string maHDBan)
        {
            return dalhdb.xoaHDB(maHDBan);
        }
    }
}
