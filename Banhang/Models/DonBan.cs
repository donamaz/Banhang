using System;
using System.Collections.Generic;

namespace Banhang.Models
{
    public partial class DonBan
    {
        public DonBan()
        {
            CtDonBans = new HashSet<CtDonBan>();
        }

        public int Id { get; set; }
        public int? IdKh { get; set; }
        public DateTime? NgayMua { get; set; }
        public double? TongTien { get; set; }
        public string? PtthanhToan { get; set; }
        public string? TrangThai { get; set; }
        public string? GhiChu { get; set; }

        public virtual KhachHang? IdKhNavigation { get; set; }
        public virtual ICollection<CtDonBan> CtDonBans { get; set; }
    }
}
