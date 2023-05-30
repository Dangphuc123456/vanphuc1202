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
    public class BUS_Nhanvien
    {
        DAL_Nhanvien dalnv = new DAL_Nhanvien();
        public DataTable getNhanvien()
        {
            return dalnv.getNhanvien();
        }
        public int kiemtramatrung(string maNhanvien)
        {
            return dalnv.kiemtramatrung(maNhanvien);
        }
        public bool themNV(Nhanvien nv)
        {
            return dalnv.themNV(nv);
        }
        public bool suaNV(Nhanvien nv)
        {
            return dalnv.suaNV(nv);
        }
        public bool xoaNV(string maNhanVien)
        {
            return dalnv.xoaNV(maNhanVien);
        }
    }
}
