using System;
using System.Collections.Generic;

namespace Banhang.Models
{
    public partial class ChiTietKhuyenMai
    {
        public ChiTietKhuyenMai()
        {
            KhuyenMais = new HashSet<KhuyenMai>();
        }

        public int Id { get; set; }
        public int IdSp { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int MaKhuyenMai { get; set; }
        public bool TrangThai { get; set; }

        public virtual SanPham IdSpNavigation { get; set; } = null!;
        public virtual ICollection<KhuyenMai> KhuyenMais { get; set; }
    }
}
