﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ResortProjectAPI.ModelEF;

namespace ResortProjectAPI.Migrations
{
    [DbContext(typeof(ResortDBContext))]
    [Migration("20210519075915_UpdateDB-Room")]
    partial class UpdateDBRoom
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ResortProjectAPI.ModelEF.Booking", b =>
                {
                    b.Property<string>("ID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Adult")
                        .HasColumnType("int");

                    b.Property<DateTime>("CheckinDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CheckoutDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Child")
                        .HasColumnType("int");

                    b.Property<string>("CustomerID")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FeedBack")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rate")
                        .HasColumnType("int");

                    b.Property<string>("RoomID")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("StaffID")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VoucherCode")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("RoomID");

                    b.HasIndex("StaffID");

                    b.HasIndex("VoucherCode");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.BookingServices", b =>
                {
                    b.Property<string>("BookingID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ServiceID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("BookingID", "ServiceID");

                    b.HasIndex("ServiceID");

                    b.ToTable("BookingServices");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.Customer", b =>
                {
                    b.Property<string>("ID")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("Birth")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Phone")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.Image", b =>
                {
                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoomID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("URL");

                    b.HasIndex("RoomID");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.Permission", b =>
                {
                    b.Property<string>("ID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.Room", b =>
                {
                    b.Property<string>("ID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Adult")
                        .HasColumnType("int");

                    b.Property<int>("Child")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeID")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.HasIndex("TypeID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.RoomType", b =>
                {
                    b.Property<string>("ID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("NameType")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.ToTable("RoomTypes");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.Rule", b =>
                {
                    b.Property<string>("RuleCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Condition")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RuleCode");

                    b.ToTable("Rules");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.Service", b =>
                {
                    b.Property<string>("ID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.Staff", b =>
                {
                    b.Property<string>("ID")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("Birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PermissionID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.HasIndex("PermissionID");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.SuppliesForRoom", b =>
                {
                    b.Property<string>("RoomID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("SupplyID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.HasKey("RoomID", "SupplyID");

                    b.HasIndex("SupplyID");

                    b.ToTable("SuppliesForRooms");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.Supply", b =>
                {
                    b.Property<string>("ID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Supplies");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.Voucher", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Condition")
                        .HasColumnType("int");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Code");

                    b.ToTable("Vouchers");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.Booking", b =>
                {
                    b.HasOne("ResortProjectAPI.ModelEF.Customer", "Customer")
                        .WithMany("Bookings")
                        .HasForeignKey("CustomerID");

                    b.HasOne("ResortProjectAPI.ModelEF.Room", "Room")
                        .WithMany("Bookings")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResortProjectAPI.ModelEF.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffID");

                    b.HasOne("ResortProjectAPI.ModelEF.Voucher", "Voucher")
                        .WithMany("Bookings")
                        .HasForeignKey("VoucherCode");

                    b.Navigation("Customer");

                    b.Navigation("Room");

                    b.Navigation("Staff");

                    b.Navigation("Voucher");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.BookingServices", b =>
                {
                    b.HasOne("ResortProjectAPI.ModelEF.Booking", "Booking")
                        .WithMany("Services")
                        .HasForeignKey("BookingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResortProjectAPI.ModelEF.Service", "Service")
                        .WithMany("Bookings")
                        .HasForeignKey("ServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.Image", b =>
                {
                    b.HasOne("ResortProjectAPI.ModelEF.Room", "Room")
                        .WithMany("Images")
                        .HasForeignKey("RoomID");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.Room", b =>
                {
                    b.HasOne("ResortProjectAPI.ModelEF.RoomType", "RoomType")
                        .WithMany("Rooms")
                        .HasForeignKey("TypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.Staff", b =>
                {
                    b.HasOne("ResortProjectAPI.ModelEF.Permission", "Permission")
                        .WithMany("Staffs")
                        .HasForeignKey("PermissionID");

                    b.Navigation("Permission");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.SuppliesForRoom", b =>
                {
                    b.HasOne("ResortProjectAPI.ModelEF.Room", "Room")
                        .WithMany("Supplies")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResortProjectAPI.ModelEF.Supply", "Supply")
                        .WithMany("Rooms")
                        .HasForeignKey("SupplyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");

                    b.Navigation("Supply");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.Booking", b =>
                {
                    b.Navigation("Services");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.Customer", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.Permission", b =>
                {
                    b.Navigation("Staffs");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.Room", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Images");

                    b.Navigation("Supplies");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.RoomType", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.Service", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.Supply", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("ResortProjectAPI.ModelEF.Voucher", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
