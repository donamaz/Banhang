using System;
using System.Collections.Generic;

namespace Banhang.Models
{
    public partial class NhaCungCap
    {
        public NhaCungCap()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public int Id { get; set; }
        public string? TenNcc { get; set; }
        public string? DiachiNcc { get; set; }
        public string? Email { get; set; }
        public string? Sdt { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
