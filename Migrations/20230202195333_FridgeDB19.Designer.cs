﻿// <auto-generated />
using System;
using FutureFridges.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FutureFridges.Migrations
{
    [DbContext(typeof(FridgeDBContext))]
    [Migration("20230202195333_FridgeDB19")]
    partial class FridgeDB19
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FutureFridges.Business.Admin.Settings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("Administrator_UID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Settings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdministratorUID = new Guid("56fada2a-2b97-43d7-99a2-c19179a28c57"),
                            UID = new Guid("2202dcd0-3e82-49a0-964c-c96ee5de2467")
                        });
                });

            modelBuilder.Entity("FutureFridges.Business.AuditLog.LogEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EventTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("LogType")
                        .HasColumnType("int");

                    b.Property<Guid>("UID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserSupplierName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AuditLogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "This is an example log entry",
                            EventTime = new DateTime(2023, 2, 2, 19, 53, 33, 267, DateTimeKind.Local).AddTicks(6008),
                            LogType = 1,
                            UID = new Guid("c3f5ff9b-451a-4023-8554-ddefdca45273"),
                            UserSupplierName = "SampleUser"
                        });
                });

            modelBuilder.Entity("FutureFridges.Business.Notifications.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("Product_UID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("StockItem_UID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("User_UID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("FutureFridges.Business.OrderManagement.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("NumberOfItems")
                        .HasColumnType("int");

                    b.Property<int>("PinCode")
                        .HasColumnType("int");

                    b.Property<Guid?>("Supplier_UID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NumberOfItems = 3,
                            PinCode = 1001,
                            UID = new Guid("215fde49-288d-41e8-a768-583b01f2ee9d")
                        });
                });

            modelBuilder.Entity("FutureFridges.Business.OrderManagement.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("Order_UID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Product_UID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("Supplier_UID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OrderUID = new Guid("215fde49-288d-41e8-a768-583b01f2ee9d"),
                            ProductUID = new Guid("c0c1847b-1007-4e1e-820e-86976226c158"),
                            Quantity = 3,
                            SupplierUID = new Guid("00000000-0000-0000-0000-000000000000"),
                            UID = new Guid("35c8c206-cc43-461b-8b8a-5d0be93fa6a3")
                        });
                });

            modelBuilder.Entity("FutureFridges.Business.OrderManagement.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "petelampy@gmail.com",
                            Name = "Satisfactory Cheeses",
                            UID = new Guid("a27ccab3-cdf9-4888-a2fa-d16a3462ad9a")
                        });
                });

            modelBuilder.Entity("FutureFridges.Business.StockManagement.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<int>("DaysShelfLife")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MinimumStockLevel")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Supplier_UID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = 2,
                            DaysShelfLife = 5,
                            ImageName = "cheese.jpeg",
                            MinimumStockLevel = 2,
                            Name = "CHEESE",
                            SupplierUID = new Guid("a27ccab3-cdf9-4888-a2fa-d16a3462ad9a"),
                            UID = new Guid("c0c1847b-1007-4e1e-820e-86976226c158")
                        });
                });

            modelBuilder.Entity("FutureFridges.Business.StockManagement.StockItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Item_UID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Product_UID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("StockItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExpiryDate = new DateTime(2023, 2, 2, 19, 53, 33, 267, DateTimeKind.Local).AddTicks(5862),
                            ItemUID = new Guid("00000000-0000-0000-0000-000000000000"),
                            ProductUID = new Guid("c0c1847b-1007-4e1e-820e-86976226c158")
                        });
                });

            modelBuilder.Entity("FutureFridges.Business.UserManagement.FridgeUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "56fada2a-2b97-43d7-99a2-c19179a28c57",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d89f74fa-b692-4b66-bb7f-5844950dc7f8",
                            Email = "admin@fridges.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@FRIDGES.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEES/DwV6QxWB1Ck0/KEJbWvIjuJ16hxcH80jyksoy6Y7KkYpsoaAM93BpM6LJUUXVA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "eda9a3a4-8cbe-42da-8d33-bd6167199f6b",
                            TwoFactorEnabled = false,
                            UserName = "Admin",
                            UserType = 0
                        });
                });

            modelBuilder.Entity("FutureFridges.Business.UserManagement.UserPermissions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AddStock")
                        .HasColumnType("bit");

                    b.Property<bool>("CreateOrder")
                        .HasColumnType("bit");

                    b.Property<bool>("ManageHealthAndSafetyReport")
                        .HasColumnType("bit");

                    b.Property<bool>("ManageOrders")
                        .HasColumnType("bit");

                    b.Property<bool>("ManageProduct")
                        .HasColumnType("bit");

                    b.Property<bool>("ManageSuppliers")
                        .HasColumnType("bit");

                    b.Property<bool>("ManageUser")
                        .HasColumnType("bit");

                    b.Property<bool>("RemoveStock")
                        .HasColumnType("bit");

                    b.Property<Guid>("User_UID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("ViewAuditLog")
                        .HasColumnType("bit");

                    b.Property<bool>("ViewStock")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("UserPermissions");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            AddStock = true,
                            CreateOrder = true,
                            ManageHealthAndSafetyReport = true,
                            ManageOrders = true,
                            ManageProduct = true,
                            ManageSuppliers = true,
                            ManageUser = true,
                            RemoveStock = true,
                            UserUID = new Guid("56fada2a-2b97-43d7-99a2-c19179a28c57"),
                            ViewAuditLog = true,
                            ViewStock = true
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FutureFridges.Business.UserManagement.FridgeUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FutureFridges.Business.UserManagement.FridgeUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FutureFridges.Business.UserManagement.FridgeUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FutureFridges.Business.UserManagement.FridgeUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}