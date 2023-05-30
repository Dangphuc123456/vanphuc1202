using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Chitiethoadonban
    {
        public string MaCTBan { get; set; }
        public string MaHDBan { get; set; }
        public string Mamonan { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public float GiamGia { get; set; }
        public float ThanhTien { get; set; }

        public Chitiethoadonban() { }
        public Chitiethoadonban(string maCTBan, string maHDBan, string mamonan, int soLuong, float donGia, float giamGia, float thanhTien)
        {
            this.MaCTBan = maCTBan;
            this.MaHDBan = maHDBan;
            this.Mamonan = mamonan;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.GiamGia = giamGia;
            this.ThanhTien = thanhTien;
        }
    }
}
