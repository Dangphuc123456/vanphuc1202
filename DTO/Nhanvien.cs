using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nhanvien
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public DateTime NgaySinh { get; set; }

        public Nhanvien() { }

        public Nhanvien(string maNhanVien, string tenNhanVien, string gioiTinh, string diaChi, string dienThoai, DateTime ngaySinh)
        {
            this.MaNhanVien = maNhanVien;
            this.TenNhanVien = tenNhanVien;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.DienThoai = dienThoai;
            this.NgaySinh = ngaySinh;
        }
    }
}
