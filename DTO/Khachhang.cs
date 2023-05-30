using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Khachhang
    {
        public string MaKhach { get; set; }
        public string TenKhach { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }

        public Khachhang() { }
        public Khachhang(string maKhach, string tenKhach, string diaChi, string dienThoai)
        {
            this.MaKhach = maKhach;
            this.TenKhach = tenKhach;
            this.DiaChi = diaChi;
            this.DienThoai = dienThoai;
        }
    }
}
