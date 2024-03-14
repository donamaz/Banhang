using System;
using System.Collections.Generic;

namespace Banhang.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            DonBans = new HashSet<DonBan>();
        }

        public int Id { get; set; }
        public string? TenKh { get; set; }
        public string? Email { get; set; }
        public string? DiaChi { get; set; }
        public string? Sdt { get; set; }
        public string? GhiChu { get; set; }

        public virtual ICollection<DonBan> DonBans { get; set; }
    }
}
