using System;
using System.Collections.Generic;

namespace Banhang.Models
{
    public partial class HoaDonNhap
    {
        public HoaDonNhap()
        {
            ChiTietHoaDonNhaps = new HashSet<ChiTietHoaDonNhap>();
        }

        public int Id { get; set; }
        public int IdSp { get; set; }
        public int IdNv { get; set; }
        public DateTime NgayNhap { get; set; }

        public virtual NhanVien IdNvNavigation { get; set; } = null!;
        public virtual SanPham IdSpNavigation { get; set; } = null!;
        public virtual ICollection<ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; }
    }
}
