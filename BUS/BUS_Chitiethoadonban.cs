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
    public class BUS_Chitiethoadonban
    {
        DAL_Chitiethoadonban dalcthdb = new DAL_Chitiethoadonban();
        public DataTable getChiTietHDBan()
        {
            return dalcthdb.getChiTietHDBan();
        }
        public int kiemtramatrung(string maCTBan)
        {
            return dalcthdb.kiemtramatrung(maCTBan);
        }
        public bool themCTHDB(Chitiethoadonban cthdb)
        {
            return dalcthdb.themCTHDB(cthdb);
        }
        public bool suaCTHDB(Chitiethoadonban cthdb)
        {
            return dalcthdb.suaCTHDB(cthdb);
        }
        public bool xoaCTHDB(string maCTBan)
        {
            return dalcthdb.xoaCTHDB(maCTBan);
        }
    }
}
