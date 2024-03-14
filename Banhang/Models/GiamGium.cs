using System;
using System.Collections.Generic;

namespace Banhang.Models
{
    public partial class GiamGium
    {
        public int Id { get; set; }
        public int? IdSp { get; set; }
        public double? PhanTram { get; set; }
        public DateTime? ThoiGianBatDau { get; set; }
        public DateTime? ThoiGianKetThuc { get; set; }
        public bool? TrangThai { get; set; }

        public virtual SanPham? IdSpNavigation { get; set; }
    }
}
