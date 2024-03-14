using System;
using System.Collections.Generic;

namespace Banhang.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            ChiTietGioHangs = new HashSet<ChiTietGioHang>();
            ChiTietKhuyenMais = new HashSet<ChiTietKhuyenMai>();
            CtDonBans = new HashSet<CtDonBan>();
            GiamGia = new HashSet<GiamGium>();
            HoaDonNhaps = new HashSet<HoaDonNhap>();
        }

        public int Id { get; set; }
        public string? Tensp { get; set; }
        public int? IdDm { get; set; }
        public int? IdNcc { get; set; }
        public string? MotaSp { get; set; }
        public double? Gia { get; set; }
        public int? SoLuong { get; set; }
        public string? Anh { get; set; }
        public DateTime? NgayTao { get; set; }

        public virtual DanhMuc? IdDmNavigation { get; set; }
        public virtual NhaCungCap? IdNccNavigation { get; set; }
        public virtual ICollection<ChiTietGioHang> ChiTietGioHangs { get; set; }
        public virtual ICollection<ChiTietKhuyenMai> ChiTietKhuyenMais { get; set; }
        public virtual ICollection<CtDonBan> CtDonBans { get; set; }
        public virtual ICollection<GiamGium> GiamGia { get; set; }
        public virtual ICollection<HoaDonNhap> HoaDonNhaps { get; set; }
    }
}
