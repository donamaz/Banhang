using System;
using System.Collections.Generic;

namespace Banhang.Models
{
    public partial class NguoiDung
    {
        public int Id { get; set; }
        public string? Ten { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public string? Gt { get; set; }
        public string? Anh { get; set; }
        public string? DiaChi { get; set; }
        public string? Email { get; set; }
    }
}
