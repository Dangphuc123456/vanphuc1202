using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hoadonban
    {
        public string MaHDBan { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayBan { get; set; }
        public string MaKhach { get; set; }
        public float TongTien { get; set; }
        public Hoadonban() { }
        public Hoadonban(string maHDBan, string maNhanVien, DateTime ngayBan, string maKhach, float tongTien)
        {
            this.MaHDBan = maHDBan;
            this.MaNhanVien = maNhanVien;
            this.NgayBan = ngayBan;
            this.MaKhach = maKhach;
            this.TongTien = tongTien;
        }
    }
}
