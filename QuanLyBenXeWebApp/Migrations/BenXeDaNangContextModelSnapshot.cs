﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyBenXeWebApp.Models;

namespace QuanLyBenXeWebApp.Migrations
{
    [DbContext(typeof(BenXeDaNangContext))]
    partial class BenXeDaNangContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuanLyBenXeWebApp.Models.DiemDung", b =>
                {
                    b.Property<string>("MaDiemDung")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<string>("HuyenQuan")
                        .HasMaxLength(50);

                    b.Property<string>("SoNhaDuong")
                        .HasMaxLength(40);

                    b.Property<string>("TenTinhTp")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("ThonAp")
                        .HasMaxLength(50);

                    b.Property<string>("XaPhuong")
                        .HasMaxLength(50);

                    b.HasKey("MaDiemDung");

                    b.ToTable("DiemDung");
                });

            modelBuilder.Entity("QuanLyBenXeWebApp.Models.NhaXe", b =>
                {
                    b.Property<string>("MaNhaXe")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<string>("DiaChi")
                        .HasMaxLength(60);

                    b.Property<string>("MaQTV")
                        .HasMaxLength(10);

                    b.Property<string>("MauBieuTuong")
                        .HasMaxLength(9);

                    b.Property<string>("Sdt")
                        .HasMaxLength(12);

                    b.Property<int>("SoLuongXe");

                    b.Property<string>("TenNhaXe")
                        .HasMaxLength(40);

                    b.HasKey("MaNhaXe");

                    b.ToTable("NhaXe");
                });

            modelBuilder.Entity("QuanLyBenXeWebApp.Models.TTBenXe", b =>
                {
                    b.Property<int>("Stt")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("GioNhapBen");

                    b.Property<string>("MaViTri")
                        .HasMaxLength(10);

                    b.Property<string>("MaXeKhach")
                        .HasMaxLength(10);

                    b.HasKey("Stt");

                    b.HasIndex("MaViTri");

                    b.HasIndex("MaXeKhach");

                    b.ToTable("TTBenXe");
                });

            modelBuilder.Entity("QuanLyBenXeWebApp.Models.TaiXe", b =>
                {
                    b.Property<string>("MaTaiXe")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<string>("HoDem")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<bool>("NamGioi");

                    b.Property<string>("NoiSinh")
                        .HasMaxLength(50);

                    b.Property<string>("Sdt")
                        .HasMaxLength(12);

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("MaTaiXe");

                    b.ToTable("TaiXe");
                });

            modelBuilder.Entity("QuanLyBenXeWebApp.Models.ViTroDo", b =>
                {
                    b.Property<string>("MaViTri")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.HasKey("MaViTri");

                    b.ToTable("ViTroDo");
                });

            modelBuilder.Entity("QuanLyBenXeWebApp.Models.XeKhach", b =>
                {
                    b.Property<string>("MaXeKhach")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<string>("BienSoXe")
                        .HasMaxLength(12);

                    b.Property<int>("GiaVe");

                    b.Property<DateTime>("GiaoDichCuoi");

                    b.Property<string>("LoaiXe")
                        .HasMaxLength(20);

                    b.Property<string>("MaNhaXe")
                        .HasMaxLength(10);

                    b.Property<string>("MaTaiXe")
                        .HasMaxLength(10);

                    b.Property<int>("SoGhe");

                    b.HasKey("MaXeKhach");

                    b.HasIndex("MaNhaXe");

                    b.HasIndex("MaTaiXe")
                        .IsUnique()
                        .HasFilter("[MaTaiXe] IS NOT NULL");

                    b.ToTable("XeKhach");
                });

            modelBuilder.Entity("QuanLyBenXeWebApp.Models.XeKhachDiemDung", b =>
                {
                    b.Property<int>("Stt")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan>("GioDiKhoiDN");

                    b.Property<TimeSpan>("GioDiToiDN");

                    b.Property<string>("MaDiemDung")
                        .HasMaxLength(10);

                    b.Property<string>("MaXeKhach")
                        .HasMaxLength(10);

                    b.Property<TimeSpan>("TGDCkhoiDN");

                    b.Property<TimeSpan>("TGDCtoiDN");

                    b.HasKey("Stt");

                    b.HasIndex("MaDiemDung");

                    b.HasIndex("MaXeKhach", "MaDiemDung", "GioDiKhoiDN", "GioDiToiDN", "TGDCkhoiDN", "TGDCtoiDN")
                        .IsUnique()
                        .HasFilter("[MaXeKhach] IS NOT NULL AND [MaDiemDung] IS NOT NULL");

                    b.ToTable("XeKhachDiemDung");
                });

            modelBuilder.Entity("QuanLyBenXeWebApp.Models.TTBenXe", b =>
                {
                    b.HasOne("QuanLyBenXeWebApp.Models.ViTroDo", "ViTroDo")
                        .WithMany()
                        .HasForeignKey("MaViTri");

                    b.HasOne("QuanLyBenXeWebApp.Models.XeKhach", "XeKhach")
                        .WithMany()
                        .HasForeignKey("MaXeKhach");
                });

            modelBuilder.Entity("QuanLyBenXeWebApp.Models.XeKhach", b =>
                {
                    b.HasOne("QuanLyBenXeWebApp.Models.NhaXe", "NhaXe")
                        .WithMany("XeKhachList")
                        .HasForeignKey("MaNhaXe");

                    b.HasOne("QuanLyBenXeWebApp.Models.TaiXe", "TaiXe")
                        .WithOne("XeKhach")
                        .HasForeignKey("QuanLyBenXeWebApp.Models.XeKhach", "MaTaiXe");
                });

            modelBuilder.Entity("QuanLyBenXeWebApp.Models.XeKhachDiemDung", b =>
                {
                    b.HasOne("QuanLyBenXeWebApp.Models.DiemDung", "DiemDung")
                        .WithMany("XeKhachList")
                        .HasForeignKey("MaDiemDung");

                    b.HasOne("QuanLyBenXeWebApp.Models.XeKhach", "XeKhach")
                        .WithMany("DiemDungList")
                        .HasForeignKey("MaXeKhach");
                });
#pragma warning restore 612, 618
        }
    }
}
