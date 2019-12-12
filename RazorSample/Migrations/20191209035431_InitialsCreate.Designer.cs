﻿// <auto-generated />
using System;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace RazorSample.Migrations
{
    [DbContext(typeof(HeThongQuanLyVPGTContext))]
    [Migration("20191209035431_InitialsCreate")]
    partial class InitialsCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("ApplicationCore.Entities.BangLai", b =>
                {
                    b.Property<int>("BangLaiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("HanSuDung")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaBangLai")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("NgayCap")
                        .HasColumnType("TEXT");

                    b.Property<int>("NguoiDieuKhienID")
                        .HasColumnType("INTEGER");

                    b.HasKey("BangLaiID");

                    b.HasIndex("NguoiDieuKhienID");

                    b.ToTable("DanhSachBangLai");
                });

            modelBuilder.Entity("ApplicationCore.Entities.BienBan", b =>
                {
                    b.Property<int>("BienBanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CanBoID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaBienBan")
                        .HasColumnType("TEXT");

                    b.Property<int>("NguoiDieuKhienID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PhuongTienID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ThoiGian")
                        .HasColumnType("TEXT");

                    b.Property<double>("TienPhat")
                        .HasColumnType("REAL");

                    b.Property<int>("TuyenDuongID")
                        .HasColumnType("INTEGER");

                    b.HasKey("BienBanID");

                    b.HasIndex("CanBoID");

                    b.HasIndex("NguoiDieuKhienID");

                    b.HasIndex("PhuongTienID");

                    b.HasIndex("TuyenDuongID");

                    b.ToTable("DanhSachBienBan");
                });

            modelBuilder.Entity("ApplicationCore.Entities.CanBo", b =>
                {
                    b.Property<int>("CanBoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CapBacID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChucVuID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DoiID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaCanBo")
                        .HasColumnType("TEXT");

                    b.Property<int>("TaiKhoanID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ten")
                        .HasColumnType("TEXT");

                    b.Property<int>("TrangThai")
                        .HasColumnType("INTEGER");

                    b.HasKey("CanBoID");

                    b.HasIndex("CapBacID");

                    b.HasIndex("ChucVuID");

                    b.HasIndex("DoiID");

                    b.HasIndex("TaiKhoanID")
                        .IsUnique();

                    b.ToTable("DanhSachCanBo");
                });

            modelBuilder.Entity("ApplicationCore.Entities.CapBac", b =>
                {
                    b.Property<int>("CapBacID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaCapBac")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenCapBac")
                        .HasColumnType("TEXT");

                    b.HasKey("CapBacID");

                    b.ToTable("DanhSachCapBac");
                });

            modelBuilder.Entity("ApplicationCore.Entities.ChiTietBienBan", b =>
                {
                    b.Property<int>("ChiTietBienBanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BienBanID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DieuLuatID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaChiTietBienBan")
                        .HasColumnType("TEXT");

                    b.HasKey("ChiTietBienBanID");

                    b.HasIndex("BienBanID");

                    b.HasIndex("DieuLuatID");

                    b.ToTable("DanhSachChiTietBienBan");
                });

            modelBuilder.Entity("ApplicationCore.Entities.ChucVu", b =>
                {
                    b.Property<int>("ChucVuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaChucVu")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenChucVu")
                        .HasColumnType("TEXT");

                    b.HasKey("ChucVuID");

                    b.ToTable("DanhSachChucVu");
                });

            modelBuilder.Entity("ApplicationCore.Entities.ChuyenDe", b =>
                {
                    b.Property<int>("ChuyenDeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("KhuVuc")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaChuyenDe")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("TEXT");

                    b.Property<int>("TrangThai")
                        .HasColumnType("INTEGER");

                    b.HasKey("ChuyenDeID");

                    b.ToTable("DanhSachChuyenDe");
                });

            modelBuilder.Entity("ApplicationCore.Entities.DieuLuat", b =>
                {
                    b.Property<int>("DieuLuatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaDieuLuat")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ten")
                        .HasColumnType("TEXT");

                    b.Property<string>("TienPhat")
                        .HasColumnType("TEXT");

                    b.HasKey("DieuLuatID");

                    b.ToTable("DanhSachDieuLuat");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Doi", b =>
                {
                    b.Property<int>("DoiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChuyenDeID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaDoi")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenDoi")
                        .HasColumnType("TEXT");

                    b.HasKey("DoiID");

                    b.HasIndex("ChuyenDeID");

                    b.ToTable("DanhSachDoi");
                });

            modelBuilder.Entity("ApplicationCore.Entities.KhuVuc", b =>
                {
                    b.Property<int>("KhuVucID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaKhuVuc")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenKhuVuc")
                        .HasColumnType("TEXT");

                    b.HasKey("KhuVucID");

                    b.ToTable("DanhSachKhuVuc");
                });

            modelBuilder.Entity("ApplicationCore.Entities.NguoiDieuKhien", b =>
                {
                    b.Property<int>("NguoiDieuKhienID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cmnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiaChi")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ten")
                        .HasColumnType("TEXT");

                    b.HasKey("NguoiDieuKhienID");

                    b.ToTable("DanhSachNguoiDieuKhien");
                });

            modelBuilder.Entity("ApplicationCore.Entities.PhuongTien", b =>
                {
                    b.Property<int>("PhuongTienID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BKS")
                        .HasColumnType("TEXT");

                    b.Property<string>("CaVet")
                        .HasColumnType("TEXT");

                    b.Property<int>("TheLoaiPhuongTienID")
                        .HasColumnType("INTEGER");

                    b.HasKey("PhuongTienID");

                    b.HasIndex("TheLoaiPhuongTienID");

                    b.ToTable("DanhSachPhuongTien");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Quyen", b =>
                {
                    b.Property<int>("QuyenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaQuyen")
                        .HasColumnType("TEXT");

                    b.Property<string>("MoTaQuyen")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenQuyen")
                        .HasColumnType("TEXT");

                    b.HasKey("QuyenID");

                    b.ToTable("DanhSachQuyen");
                });

            modelBuilder.Entity("ApplicationCore.Entities.TaiKhoan", b =>
                {
                    b.Property<int>("TaiKhoanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MatKhau")
                        .HasColumnType("TEXT");

                    b.Property<int>("QuyenID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenTaiKhoan")
                        .HasColumnType("TEXT");

                    b.Property<int>("TrangThai")
                        .HasColumnType("INTEGER");

                    b.HasKey("TaiKhoanID");

                    b.HasIndex("QuyenID");

                    b.ToTable("DanhSachTaiKhoan");
                });

            modelBuilder.Entity("ApplicationCore.Entities.TheLoaiPhuongTien", b =>
                {
                    b.Property<int>("TheLoaiPhuongTienID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaTheLoai")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenTheLoai")
                        .HasColumnType("TEXT");

                    b.HasKey("TheLoaiPhuongTienID");

                    b.ToTable("DanhSachTheLoaiPhuongTien");
                });

            modelBuilder.Entity("ApplicationCore.Entities.TuyenDuong", b =>
                {
                    b.Property<int>("TuyenDuongID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("KhuVucID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaTuyenDuong")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenTuyenDuong")
                        .HasColumnType("TEXT");

                    b.HasKey("TuyenDuongID");

                    b.HasIndex("KhuVucID");

                    b.ToTable("DanhSachTuyenDuong");
                });

            modelBuilder.Entity("ApplicationCore.Entities.BangLai", b =>
                {
                    b.HasOne("ApplicationCore.Entities.NguoiDieuKhien", "NguoiDieuKhien")
                        .WithMany("BangLai")
                        .HasForeignKey("NguoiDieuKhienID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationCore.Entities.BienBan", b =>
                {
                    b.HasOne("ApplicationCore.Entities.CanBo", "CanBo")
                        .WithMany("DanhSachBienBan")
                        .HasForeignKey("CanBoID");

                    b.HasOne("ApplicationCore.Entities.NguoiDieuKhien", "NguoiDieuKhien")
                        .WithMany("ListBienBan")
                        .HasForeignKey("NguoiDieuKhienID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entities.PhuongTien", "PhuongTien")
                        .WithMany("DanhSachBienBan")
                        .HasForeignKey("PhuongTienID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entities.TuyenDuong", "TuyenDuong")
                        .WithMany("DanhSachBienBan")
                        .HasForeignKey("TuyenDuongID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationCore.Entities.CanBo", b =>
                {
                    b.HasOne("ApplicationCore.Entities.CapBac", "CapBac")
                        .WithMany("DanhSachCanBo")
                        .HasForeignKey("CapBacID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entities.ChucVu", "ChucVu")
                        .WithMany("DanhSachCanBo")
                        .HasForeignKey("ChucVuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entities.Doi", "Doi")
                        .WithMany("DanhSachCanBo")
                        .HasForeignKey("DoiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entities.TaiKhoan", "TaiKhoan")
                        .WithOne("CanBo")
                        .HasForeignKey("ApplicationCore.Entities.CanBo", "TaiKhoanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationCore.Entities.ChiTietBienBan", b =>
                {
                    b.HasOne("ApplicationCore.Entities.BienBan", "BienBan")
                        .WithMany("DanhSachChiTietBienBan")
                        .HasForeignKey("BienBanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entities.DieuLuat", "DieuLuat")
                        .WithMany("DanhSachChiTietBienBan")
                        .HasForeignKey("DieuLuatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationCore.Entities.Doi", b =>
                {
                    b.HasOne("ApplicationCore.Entities.ChuyenDe", "ChuyenDe")
                        .WithMany("DanhSachDoi")
                        .HasForeignKey("ChuyenDeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationCore.Entities.PhuongTien", b =>
                {
                    b.HasOne("ApplicationCore.Entities.TheLoaiPhuongTien", "TheLoaiPhuongTien")
                        .WithMany("DanhSachPhuongTien")
                        .HasForeignKey("TheLoaiPhuongTienID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationCore.Entities.TaiKhoan", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Quyen", "Quyen")
                        .WithMany("DanhSachTaiKhoan")
                        .HasForeignKey("QuyenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationCore.Entities.TuyenDuong", b =>
                {
                    b.HasOne("ApplicationCore.Entities.KhuVuc", null)
                        .WithMany("DanhSachTuyenDuong")
                        .HasForeignKey("KhuVucID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}