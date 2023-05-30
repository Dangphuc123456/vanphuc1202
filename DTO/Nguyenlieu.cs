using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nguyenlieu
    {
        public string MaNguyenLieu { get; set; }
        public string TenNguyenLieu { get; set; }
        public float SoLuong { get; set; }
        public float DonGiaNhap { get; set; }
        public string GhiChu { get; set; }
        public Nguyenlieu() { }
        public Nguyenlieu(string maNguyenLieu, string tenNguyenLieu, float soLuong, float donGiaNhap, string ghiChu)
        {
            this.MaNguyenLieu = maNguyenLieu;
            this.TenNguyenLieu = tenNguyenLieu;
            this.SoLuong = soLuong;
            this.DonGiaNhap = donGiaNhap;
            this.GhiChu = ghiChu;
        }
    }
}
