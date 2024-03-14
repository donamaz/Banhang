using System;
using System.Collections.Generic;

namespace Banhang.Models
{
    public partial class ChiTietGioHang
    {
        public int Id { get; set; }
        public int IdSp { get; set; }
        public int IdKh { get; set; }
        public int IdGioHang { get; set; }
        public int? SoLuong { get; set; }

        public virtual GioHang IdGioHangNavigation { get; set; } = null!;
        public virtual SanPham IdSpNavigation { get; set; } = null!;
    }
}
