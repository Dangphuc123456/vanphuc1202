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
    public class BUS_Nhacungcap
    {

        DAL_Nhacungcap dalncc = new DAL_Nhacungcap();
        public DataTable getNhaCC()
        {
            return dalncc.getNhaCC();
        }
        public int kiemtramatrung(string nhaCCID)
        {
            return dalncc.kiemtramatrung(nhaCCID);
        }
        public bool themNCC(Nhacungcap ncc)
        {
            return dalncc.themNCC(ncc);
        }
        public bool suaNCC(Nhacungcap ncc)
        {
            return dalncc.suaNCC(ncc);
        }
        public bool xoaNCC(string nhaCCID)
        {
            return dalncc.xoaNCC(nhaCCID);
        }
    }
}
