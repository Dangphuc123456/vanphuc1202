using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Chitiethoadonnhap
    {
        public string MaCTNhap { get; set; }
        public string MaHDNhap { get; set; }
        public string MaNguyenlieu { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }
        public Chitiethoadonnhap() { }
        public Chitiethoadonnhap(string maCTNhap, string maHDNhap, string maNguyenlieu, int soLuong, float donGia, float thanhTien)
        {
            this.MaCTNhap = maCTNhap;
            this.MaHDNhap = maHDNhap;
            this.MaNguyenlieu = maNguyenlieu;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.ThanhTien = thanhTien;
        }
    }
}
