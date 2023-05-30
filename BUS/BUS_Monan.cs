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
    public class BUS_Monan
    {
        DAL_Monan dalma = new DAL_Monan();
        public DataTable getMonan()
        {
            return dalma.getMonan();
        }
        public int kiemtramatrung(string mamonan)
        {
            return dalma.kiemtramatrung(mamonan);
        }
        public bool themMA(Monan ma)
        {
            return dalma.themMA(ma);
        }
        public bool suaMA(Monan ma)
        {
            return dalma.suaMA(ma);
        }
        public bool xoaMA(string mamonan)
        {
            return dalma.xoaMA(mamonan);
        }
    }
}
