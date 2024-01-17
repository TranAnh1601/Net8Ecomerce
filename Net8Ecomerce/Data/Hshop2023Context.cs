﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net8Ecomerce.Data;

public partial class Hshop2023Context : DbContext
{
    public Hshop2023Context()
    {
    }

    public Hshop2023Context(DbContextOptions<Hshop2023Context> options)
        : base(options)
    {
    }

    public virtual DbSet<BanBe> BanBes { get; set; }

    public virtual DbSet<ChiTietHd> ChiTietHds { get; set; }

    public virtual DbSet<ChuDe> ChuDes { get; set; }

    public virtual DbSet<GopY> Gopies { get; set; }

    public virtual DbSet<HangHoa> HangHoas { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<HoiDap> HoiDaps { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<Loai> Loais { get; set; }

    public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<PhanCong> PhanCongs { get; set; }

    public virtual DbSet<PhanQuyen> PhanQuyens { get; set; }

    public virtual DbSet<PhongBan> PhongBans { get; set; }

    public virtual DbSet<TrangThai> TrangThais { get; set; }

    public virtual DbSet<TrangWeb> TrangWebs { get; set; }

    public virtual DbSet<VChiTietHoaDon> VChiTietHoaDons { get; set; }

    public virtual DbSet<YeuThich> YeuThiches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-39O3ODF\\SQLEXPRESS;Initial Catalog=Hshop2023;User ID=sa;Password=sa;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BanBe>(entity =>
        {
            entity.HasKey(e => e.MaBb).HasName("PK_Promotions");

            entity.ToTable("BanBe");

            entity.Property(e => e.MaBb).HasColumnName("MaBB");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.HoTen).HasMaxLength(50);
            entity.Property(e => e.MaHh).HasColumnName("MaHH");
            entity.Property(e => e.MaKh)
                .HasMaxLength(20)
                .HasColumnName("MaKH");
            entity.Property(e => e.NgayGui).HasColumnType("datetime");
        });

        modelBuilder.Entity<ChiTietHd>(entity =>
        {
            entity.HasKey(e => e.MaCt).HasName("PK_OrderDetails");

            entity.ToTable("ChiTietHD");

            entity.Property(e => e.MaCt).HasColumnName("MaCT");
            entity.Property(e => e.MaHd).HasColumnName("MaHD");
            entity.Property(e => e.MaHh).HasColumnName("MaHH");
        });

        modelBuilder.Entity<ChuDe>(entity =>
        {
            entity.HasKey(e => e.MaCd);

            entity.ToTable("ChuDe");

            entity.Property(e => e.MaCd).HasColumnName("MaCD");
            entity.Property(e => e.MaNv)
                .HasMaxLength(50)
                .HasColumnName("MaNV");
            entity.Property(e => e.TenCd)
                .HasMaxLength(50)
                .HasColumnName("TenCD");
        });

        modelBuilder.Entity<GopY>(entity =>
        {
            entity.HasKey(e => e.MaGy);

            entity.ToTable("GopY");

            entity.Property(e => e.MaGy)
                .HasMaxLength(50)
                .HasColumnName("MaGY");
            entity.Property(e => e.DienThoai).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.HoTen).HasMaxLength(50);
            entity.Property(e => e.MaCd).HasColumnName("MaCD");
            entity.Property(e => e.NgayGy).HasColumnName("NgayGY");
            entity.Property(e => e.NgayTl).HasColumnName("NgayTL");
            entity.Property(e => e.TraLoi).HasMaxLength(50);
        });

        modelBuilder.Entity<HangHoa>(entity =>
        {
            entity.HasKey(e => e.MaHh).HasName("PK_Products");

            entity.ToTable("HangHoa");

            entity.Property(e => e.MaHh).HasColumnName("MaHH");
            entity.Property(e => e.Hinh).HasMaxLength(50);
            entity.Property(e => e.MaNcc)
                .HasMaxLength(50)
                .HasColumnName("MaNCC");
            entity.Property(e => e.MoTaDonVi).HasMaxLength(50);
            entity.Property(e => e.NgaySx)
                .HasColumnType("datetime")
                .HasColumnName("NgaySX");
            entity.Property(e => e.TenAlias).HasMaxLength(50);
            entity.Property(e => e.TenHh)
                .HasMaxLength(50)
                .HasColumnName("TenHH");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHd).HasName("PK_Orders");

            entity.ToTable("HoaDon");

            entity.Property(e => e.MaHd).HasColumnName("MaHD");
            entity.Property(e => e.CachThanhToan).HasMaxLength(50);
            entity.Property(e => e.CachVanChuyen).HasMaxLength(50);
            entity.Property(e => e.DiaChi).HasMaxLength(60);
            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.HoTen).HasMaxLength(50);
            entity.Property(e => e.MaKh)
                .HasMaxLength(20)
                .HasColumnName("MaKH");
            entity.Property(e => e.MaNv)
                .HasMaxLength(50)
                .HasColumnName("MaNV");
            entity.Property(e => e.NgayCan).HasColumnType("datetime");
            entity.Property(e => e.NgayDat).HasColumnType("datetime");
            entity.Property(e => e.NgayGiao).HasColumnType("datetime");
        });

        modelBuilder.Entity<HoiDap>(entity =>
        {
            entity.HasKey(e => e.MaHd);

            entity.ToTable("HoiDap");

            entity.Property(e => e.MaHd)
                .ValueGeneratedNever()
                .HasColumnName("MaHD");
            entity.Property(e => e.CauHoi).HasMaxLength(50);
            entity.Property(e => e.MaNv)
                .HasMaxLength(50)
                .HasColumnName("MaNV");
            entity.Property(e => e.TraLoi).HasMaxLength(50);
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKh).HasName("PK_Customers");

            entity.ToTable("KhachHang");

            entity.Property(e => e.MaKh)
                .HasMaxLength(20)
                .HasColumnName("MaKH");
            entity.Property(e => e.DiaChi).HasMaxLength(60);
            entity.Property(e => e.DienThoai).HasMaxLength(24);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Hinh).HasMaxLength(50);
            entity.Property(e => e.HoTen).HasMaxLength(50);
            entity.Property(e => e.MatKhau).HasMaxLength(50);
            entity.Property(e => e.NgaySinh).HasColumnType("datetime");
            entity.Property(e => e.RandomKey)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Loai>(entity =>
        {
            entity.HasKey(e => e.MaLoai).HasName("PK_Categories");

            entity.ToTable("Loai");

            entity.Property(e => e.Hinh).HasMaxLength(50);
            entity.Property(e => e.TenLoai).HasMaxLength(50);
            entity.Property(e => e.TenLoaiAlias).HasMaxLength(50);
        });

        modelBuilder.Entity<NhaCungCap>(entity =>
        {
            entity.HasKey(e => e.MaNcc).HasName("PK_Suppliers");

            entity.ToTable("NhaCungCap");

            entity.Property(e => e.MaNcc)
                .HasMaxLength(50)
                .HasColumnName("MaNCC");
            entity.Property(e => e.DiaChi).HasMaxLength(50);
            entity.Property(e => e.DienThoai).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Logo).HasMaxLength(50);
            entity.Property(e => e.NguoiLienLac).HasMaxLength(50);
            entity.Property(e => e.TenCongTy).HasMaxLength(50);
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNv);

            entity.ToTable("NhanVien");

            entity.Property(e => e.MaNv)
                .HasMaxLength(50)
                .HasColumnName("MaNV");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.HoTen).HasMaxLength(50);
            entity.Property(e => e.MatKhau).HasMaxLength(50);
        });

        modelBuilder.Entity<PhanCong>(entity =>
        {
            entity.HasKey(e => e.MaPc);

            entity.ToTable("PhanCong");

            entity.Property(e => e.MaPc).HasColumnName("MaPC");
            entity.Property(e => e.MaNv)
                .HasMaxLength(50)
                .HasColumnName("MaNV");
            entity.Property(e => e.MaPb)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("MaPB");
            entity.Property(e => e.NgayPc)
                .HasColumnType("datetime")
                .HasColumnName("NgayPC");
        });

        modelBuilder.Entity<PhanQuyen>(entity =>
        {
            entity.HasKey(e => e.MaPq);

            entity.ToTable("PhanQuyen");

            entity.Property(e => e.MaPq).HasColumnName("MaPQ");
            entity.Property(e => e.MaPb)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("MaPB");
        });

        modelBuilder.Entity<PhongBan>(entity =>
        {
            entity.HasKey(e => e.MaPb);

            entity.ToTable("PhongBan");

            entity.Property(e => e.MaPb)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("MaPB");
            entity.Property(e => e.TenPb)
                .HasMaxLength(50)
                .HasColumnName("TenPB");
        });

        modelBuilder.Entity<TrangThai>(entity =>
        {
            entity.HasKey(e => e.MaTrangThai);

            entity.ToTable("TrangThai");

            entity.Property(e => e.MaTrangThai).ValueGeneratedNever();
            entity.Property(e => e.MoTa).HasMaxLength(500);
            entity.Property(e => e.TenTrangThai).HasMaxLength(50);
        });

        modelBuilder.Entity<TrangWeb>(entity =>
        {
            entity.HasKey(e => e.MaTrang);

            entity.ToTable("TrangWeb");

            entity.Property(e => e.TenTrang).HasMaxLength(50);
            entity.Property(e => e.Url)
                .HasMaxLength(250)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<VChiTietHoaDon>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vChiTietHoaDon");

            entity.Property(e => e.MaCt).HasColumnName("MaCT");
            entity.Property(e => e.MaHd).HasColumnName("MaHD");
            entity.Property(e => e.MaHh).HasColumnName("MaHH");
            entity.Property(e => e.TenHh)
                .HasMaxLength(50)
                .HasColumnName("TenHH");
        });

        modelBuilder.Entity<YeuThich>(entity =>
        {
            entity.HasKey(e => e.MaYt).HasName("PK_Favorites");

            entity.ToTable("YeuThich");

            entity.Property(e => e.MaYt).HasColumnName("MaYT");
            entity.Property(e => e.MaHh).HasColumnName("MaHH");
            entity.Property(e => e.MaKh)
                .HasMaxLength(20)
                .HasColumnName("MaKH");
            entity.Property(e => e.MoTa).HasMaxLength(255);
            entity.Property(e => e.NgayChon).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
