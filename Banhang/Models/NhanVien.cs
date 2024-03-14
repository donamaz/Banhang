using System;
using System.Collections.Generic;

namespace Banhang.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDonNhaps = new HashSet<HoaDonNhap>();
        }

        public int Id { get; set; }
        public string? TenNhanvien { get; set; }
        public string? Gioitinh { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public string? Quequan { get; set; }
        public string? Sdt { get; set; }
        public string? Email { get; set; }
        public string? Capbac { get; set; }

        public virtual ICollection<HoaDonNhap> HoaDonNhaps { get; set; }
    }
}
