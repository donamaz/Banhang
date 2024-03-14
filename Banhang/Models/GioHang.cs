using System;
using System.Collections.Generic;

namespace Banhang.Models
{
    public partial class GioHang
    {
        public GioHang()
        {
            ChiTietGioHangs = new HashSet<ChiTietGioHang>();
        }

        public int Id { get; set; }
        public DateTime? Ngay { get; set; }
        public bool? Trangthai { get; set; }

        public virtual ICollection<ChiTietGioHang> ChiTietGioHangs { get; set; }
    }
}
