using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Final_APP.Entities
{
    public partial class DVMB : DbContext
    {
        public DVMB()
            : base("name=DVMB")
        {
        }

        public virtual DbSet<ChangBay> ChangBays { get; set; }
        public virtual DbSet<ChuyenBay> ChuyenBays { get; set; }
        public virtual DbSet<HanhKhach> HanhKhaches { get; set; }
        public virtual DbSet<HinhThucThanhToan> HinhThucThanhToans { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<MayBay> MayBays { get; set; }
        public virtual DbSet<NganHang> NganHangs { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<PhieuDatVe> PhieuDatVes { get; set; }
        public virtual DbSet<SanBay> SanBays { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<Ve> Ves { get; set; }
        public virtual DbSet<XuatHoaDon> XuatHoaDons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChangBay>()
                .Property(e => e.MaChangBay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChangBay>()
                .Property(e => e.SanBay_CatCanh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChangBay>()
                .Property(e => e.SanBay_HaCanh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChuyenBay>()
                .Property(e => e.MaChuyenBay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChuyenBay>()
                .Property(e => e.TGbay)
                .HasPrecision(5);

            modelBuilder.Entity<ChuyenBay>()
                .Property(e => e.LoaiMayBay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChuyenBay>()
                .Property(e => e.Gia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ChuyenBay>()
                .Property(e => e.MaChangBay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HanhKhach>()
                .Property(e => e.MaHanhKhach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HanhKhach>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HanhKhach>()
                .Property(e => e.CMND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HanhKhach>()
                .Property(e => e.MaNguoiDung)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HinhThucThanhToan>()
                .Property(e => e.MaHinhThucTT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHoaDon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.ThanhTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaPhieuDatVe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.NgayXuatDon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHinhThucTT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaKhuyenMai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhuyenMai>()
                .Property(e => e.MaKhuyenMai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MayBay>()
                .Property(e => e.LoaiMayBay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MayBay>()
                .Property(e => e.KyHieuHang)
                .IsUnicode(false);

            modelBuilder.Entity<NganHang>()
                .Property(e => e.MaNganHang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NganHang>()
                .Property(e => e.MaHinhThucTT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MaNguoiDung)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuDatVe>()
                .Property(e => e.MaPhieuDatVe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuDatVe>()
                .Property(e => e.MaNguoiDung)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SanBay>()
                .Property(e => e.MaSanBay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SanBay>()
                .HasMany(e => e.ChangBays)
                .WithOptional(e => e.SanBay)
                .HasForeignKey(e => e.SanBay_CatCanh);

            modelBuilder.Entity<SanBay>()
                .HasMany(e => e.ChangBays1)
                .WithOptional(e => e.SanBay1)
                .HasForeignKey(e => e.SanBay_HaCanh);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<Ve>()
                .Property(e => e.MaVe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Ve>()
                .Property(e => e.MaPhieuDatVe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Ve>()
                .Property(e => e.MaLoaiVe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Ve>()
                .Property(e => e.MaChuyenBay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<XuatHoaDon>()
                .Property(e => e.MaXuat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<XuatHoaDon>()
                .Property(e => e.MaHoaDon)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
