using System;
using System.Collections.Generic;

namespace Banhang.Models
{
    public partial class Taikhoan
    {
        public int Id { get; set; }
        public string? Ten { get; set; }
        public string? TaiKhoan1 { get; set; }
        public string? MatKhau { get; set; }
        public string? Email { get; set; }
        public string? LoaiQuyen { get; set; }
    }
}
