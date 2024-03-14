using System;
using System.Collections.Generic;

namespace Banhang.Models
{
    public partial class CtDonBan
    {
        public int Id { get; set; }
        public int? IdDonBan { get; set; }
        public int? IdSp { get; set; }
        public int? Sl { get; set; }

        public virtual DonBan? IdDonBanNavigation { get; set; }
        public virtual SanPham? IdSpNavigation { get; set; }
    }
}
