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
    public class BUS_Nguyenlieu
    {
        DAL_Nguyenlieu dalnl = new DAL_Nguyenlieu();
        public DataTable getNguyenlieu()
        {
            return dalnl.getNguyenlieu();
        }
        public int kiemtramatrung(string maNguyenLieu)
        {
            return dalnl.kiemtramatrung(maNguyenLieu);
        }
        public bool themNL(Nguyenlieu nl)
        {
            return dalnl.themNL(nl);
        }
        public bool suaNL(Nguyenlieu nl)
        {
            return dalnl.suaNL(nl);
        }
        public bool xoaNL(string maNguyenLieu)
        {
            return dalnl.xoaNL(maNguyenLieu);
        }
    }
}
