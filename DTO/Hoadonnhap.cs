using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hoadonnhap
    {
        public string MaHDNhap { get; set; }
        public string MaNhanVien { get; set; }
        public string NhaCCID { get; set; }
        public DateTime NgayNhap { get; set; }
        public float TongTien { get; set; }

        public Hoadonnhap() { }
        public Hoadonnhap(string maHDNhap, string maNhanVien, string nhaCCID, DateTime ngayNhap, float tongTien)
        {
            this.MaHDNhap = maHDNhap;
            this.MaNhanVien = maNhanVien;
            this.NhaCCID = nhaCCID;
            this.NgayNhap = ngayNhap;
            this.TongTien = tongTien;
        }
    }
}
