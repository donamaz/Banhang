using System;
using System.Collections.Generic;

namespace Banhang.Models
{
    public partial class DanhMuc
    {
        public DanhMuc()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public int Id { get; set; }
        public string? Tendm { get; set; }
        public bool? Trangthai { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
