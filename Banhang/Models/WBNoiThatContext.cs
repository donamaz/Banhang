using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Banhang.Models
{
    public partial class WBNoiThatContext : DbContext
    {
        public WBNoiThatContext()
        {
        }

        public WBNoiThatContext(DbContextOptions<WBNoiThatContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietGioHang> ChiTietGioHangs { get; set; } = null!;
        public virtual DbSet<ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; } = null!;
        public virtual DbSet<ChiTietKhuyenMai> ChiTietKhuyenMais { get; set; } = null!;
        public virtual DbSet<CtDonBan> CtDonBans { get; set; } = null!;
        public virtual DbSet<DanhMuc> DanhMucs { get; set; } = null!;
        public virtual DbSet<DonBan> DonBans { get; set; } = null!;
        public virtual DbSet<GiamGium> GiamGia { get; set; } = null!;
        public virtual DbSet<GioHang> GioHangs { get; set; } = null!;
        public virtual DbSet<HoaDonNhap> HoaDonNhaps { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; } = null!;
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; } = null!;
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;
        public virtual DbSet<Slide> Slides { get; set; } = null!;
        public virtual DbSet<Taikhoan> Taikhoans { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-2LHNSSS\\SQLEXPRESS;Initial Catalog=WBNoiThat;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietGioHang>(entity =>
            {
                entity.ToTable("chi_tiet_gio_hang");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdGioHang).HasColumnName("id_gio_hang");

                entity.Property(e => e.IdKh).HasColumnName("id_kh");

                entity.Property(e => e.IdSp).HasColumnName("id_sp");

                entity.Property(e => e.SoLuong).HasColumnName("so_luong");

                entity.HasOne(d => d.IdGioHangNavigation)
                    .WithMany(p => p.ChiTietGioHangs)
                    .HasForeignKey(d => d.IdGioHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_chi_tiet_gio_hang_gio_hang1");

                entity.HasOne(d => d.IdSpNavigation)
                    .WithMany(p => p.ChiTietGioHangs)
                    .HasForeignKey(d => d.IdSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_chi_tiet_gio_hang_san_pham");
            });

            modelBuilder.Entity<ChiTietHoaDonNhap>(entity =>
            {
                entity.ToTable("chi_tiet_hoa_don_nhap");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Gia).HasColumnName("gia");

                entity.Property(e => e.IdHdn).HasColumnName("id_hdn");

                entity.Property(e => e.SoLuong).HasColumnName("so_luong");

                entity.HasOne(d => d.IdHdnNavigation)
                    .WithMany(p => p.ChiTietHoaDonNhaps)
                    .HasForeignKey(d => d.IdHdn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_chi_tiet_hoa_don_nhap_hoa_don_nhap");
            });

            modelBuilder.Entity<ChiTietKhuyenMai>(entity =>
            {
                entity.ToTable("ChiTietKhuyenMai");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdSp).HasColumnName("id_sp");

                entity.Property(e => e.NgayBatDau).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");

                entity.HasOne(d => d.IdSpNavigation)
                    .WithMany(p => p.ChiTietKhuyenMais)
                    .HasForeignKey(d => d.IdSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietKhuyenMai_san_pham");
            });

            modelBuilder.Entity<CtDonBan>(entity =>
            {
                entity.ToTable("ct_don_ban");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdDonBan).HasColumnName("id_don_ban");

                entity.Property(e => e.IdSp).HasColumnName("id_sp");

                entity.Property(e => e.Sl).HasColumnName("sl");

                entity.HasOne(d => d.IdDonBanNavigation)
                    .WithMany(p => p.CtDonBans)
                    .HasForeignKey(d => d.IdDonBan)
                    .HasConstraintName("FK_ct_don_ban_don_ban");

                entity.HasOne(d => d.IdSpNavigation)
                    .WithMany(p => p.CtDonBans)
                    .HasForeignKey(d => d.IdSp)
                    .HasConstraintName("FK_ct_don_ban_san_pham");
            });

            modelBuilder.Entity<DanhMuc>(entity =>
            {
                entity.ToTable("danh_muc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(50)
                    .HasColumnName("tendm");

                entity.Property(e => e.Trangthai).HasColumnName("trangthai");
            });

            modelBuilder.Entity<DonBan>(entity =>
            {
                entity.ToTable("don_ban");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(50)
                    .HasColumnName("ghi_chu");

                entity.Property(e => e.IdKh).HasColumnName("id_kh");

                entity.Property(e => e.NgayMua)
                    .HasColumnType("datetime")
                    .HasColumnName("ngay_mua");

                entity.Property(e => e.PtthanhToan)
                    .HasMaxLength(10)
                    .HasColumnName("ptthanh_toan")
                    .IsFixedLength();

                entity.Property(e => e.TongTien).HasColumnName("tong_tien");

                entity.Property(e => e.TrangThai)
                    .HasMaxLength(50)
                    .HasColumnName("trang_thai");

                entity.HasOne(d => d.IdKhNavigation)
                    .WithMany(p => p.DonBans)
                    .HasForeignKey(d => d.IdKh)
                    .HasConstraintName("FK_don_ban_khach_hang");
            });

            modelBuilder.Entity<GiamGium>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdSp).HasColumnName("id_sp");

                entity.Property(e => e.ThoiGianBatDau).HasColumnType("datetime");

                entity.Property(e => e.ThoiGianKetThuc).HasColumnType("datetime");

                entity.HasOne(d => d.IdSpNavigation)
                    .WithMany(p => p.GiamGia)
                    .HasForeignKey(d => d.IdSp)
                    .HasConstraintName("FK_GiamGia_san_pham");
            });

            modelBuilder.Entity<GioHang>(entity =>
            {
                entity.ToTable("gio_hang");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ngay)
                    .HasColumnType("datetime")
                    .HasColumnName("ngay");

                entity.Property(e => e.Trangthai).HasColumnName("trangthai");
            });

            modelBuilder.Entity<HoaDonNhap>(entity =>
            {
                entity.ToTable("hoa_don_nhap");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdNv).HasColumnName("id_nv");

                entity.Property(e => e.IdSp).HasColumnName("id_sp");

                entity.Property(e => e.NgayNhap).HasColumnType("datetime");

                entity.HasOne(d => d.IdNvNavigation)
                    .WithMany(p => p.HoaDonNhaps)
                    .HasForeignKey(d => d.IdNv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_hoa_don_nhap_nhan_vien");

                entity.HasOne(d => d.IdSpNavigation)
                    .WithMany(p => p.HoaDonNhaps)
                    .HasForeignKey(d => d.IdSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_hoa_don_nhap_san_pham");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.ToTable("khach_hang");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(100)
                    .HasColumnName("dia_chi");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(50)
                    .HasColumnName("ghi_chu");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .HasColumnName("sdt")
                    .IsFixedLength();

                entity.Property(e => e.TenKh)
                    .HasMaxLength(50)
                    .HasColumnName("ten_kh");
            });

            modelBuilder.Entity<KhuyenMai>(entity =>
            {
                entity.ToTable("KhuyenMai");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdKm).HasColumnName("id_km");

                entity.Property(e => e.MoTa).HasColumnType("ntext");

                entity.HasOne(d => d.IdKmNavigation)
                    .WithMany(p => p.KhuyenMais)
                    .HasForeignKey(d => d.IdKm)
                    .HasConstraintName("FK_KhuyenMai_ChiTietKhuyenMai");
            });

            modelBuilder.Entity<NguoiDung>(entity =>
            {
                entity.ToTable("nguoi_dung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Anh)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("anh");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(1500)
                    .HasColumnName("dia_chi");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Gt)
                    .HasMaxLength(20)
                    .HasColumnName("gt");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaysinh");

                entity.Property(e => e.Ten)
                    .HasMaxLength(250)
                    .HasColumnName("ten");
            });

            modelBuilder.Entity<NhaCungCap>(entity =>
            {
                entity.ToTable("nha_cung_cap");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DiachiNcc)
                    .HasMaxLength(200)
                    .HasColumnName("diachi_ncc");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .HasColumnName("sdt")
                    .IsFixedLength();

                entity.Property(e => e.TenNcc)
                    .HasMaxLength(100)
                    .HasColumnName("ten_ncc");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.ToTable("nhan_vien");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Capbac)
                    .HasMaxLength(100)
                    .HasColumnName("capbac");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Gioitinh)
                    .HasMaxLength(3)
                    .HasColumnName("gioitinh");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaysinh");

                entity.Property(e => e.Quequan)
                    .HasMaxLength(100)
                    .HasColumnName("quequan");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .HasColumnName("sdt")
                    .IsFixedLength();

                entity.Property(e => e.TenNhanvien)
                    .HasMaxLength(50)
                    .HasColumnName("ten_nhanvien");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.ToTable("san_pham");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Anh)
                    .HasMaxLength(255)
                    .HasColumnName("anh");

                entity.Property(e => e.Gia).HasColumnName("gia");

                entity.Property(e => e.IdDm).HasColumnName("id_dm");

                entity.Property(e => e.IdNcc).HasColumnName("id_ncc");

                entity.Property(e => e.MotaSp)
                    .HasMaxLength(255)
                    .HasColumnName("mota_sp");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasColumnName("ngay_tao");

                entity.Property(e => e.SoLuong).HasColumnName("so_luong");

                entity.Property(e => e.Tensp)
                    .HasMaxLength(100)
                    .HasColumnName("tensp");

                entity.HasOne(d => d.IdDmNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.IdDm)
                    .HasConstraintName("FK_san_pham_danh_muc");

                entity.HasOne(d => d.IdNccNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.IdNcc)
                    .HasConstraintName("FK_san_pham_nha_cung_cap");
            });

            modelBuilder.Entity<Slide>(entity =>
            {
                entity.HasKey(e => e.IdSlide);

                entity.ToTable("slide");

                entity.Property(e => e.IdSlide)
                    .ValueGeneratedNever()
                    .HasColumnName("id_slide");

                entity.Property(e => e.Anh)
                    .HasMaxLength(255)
                    .HasColumnName("anh");

                entity.Property(e => e.Link)
                    .HasMaxLength(100)
                    .HasColumnName("link");
            });

            modelBuilder.Entity<Taikhoan>(entity =>
            {
                entity.ToTable("taikhoan");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.LoaiQuyen)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(100)
                    .HasColumnName("matkhau");

                entity.Property(e => e.TaiKhoan1)
                    .HasMaxLength(100)
                    .HasColumnName("taikhoan");

                entity.Property(e => e.Ten)
                    .HasMaxLength(100)
                    .HasColumnName("ten");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
