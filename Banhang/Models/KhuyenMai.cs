using System;
using System.Collections.Generic;

namespace Banhang.Models
{
    public partial class KhuyenMai
    {
        public int Id { get; set; }
        public int? IdKm { get; set; }
        public string? MoTa { get; set; }

        public virtual ChiTietKhuyenMai? IdKmNavigation { get; set; }
    }
}
