using System;
using System.Collections.Generic;

namespace Banhang.Models
{
    public partial class ChiTietHoaDonNhap
    {
        public int Id { get; set; }
        public int IdHdn { get; set; }
        public int SoLuong { get; set; }
        public double Gia { get; set; }

        public virtual HoaDonNhap IdHdnNavigation { get; set; } = null!;
    }
}
