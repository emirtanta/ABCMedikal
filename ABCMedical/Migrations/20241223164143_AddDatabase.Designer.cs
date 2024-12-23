﻿// <auto-generated />
using System;
using ABCMedical.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ABCMedical.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241223164143_AddDatabase")]
    partial class AddDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ABCMedical.Models.Entities.Cart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartID"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ProductID");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("ABCMedical.Models.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<decimal>("Budget")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CustomerSurname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CustomerType")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("TotalSpent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerID = 1,
                            Budget = 25000m,
                            CustomerName = "Uğur",
                            CustomerSurname = "Çam",
                            CustomerType = 0,
                            Email = "ucam@gmail.com",
                            Password = "1",
                            TotalSpent = 1200m,
                            Username = "ucam"
                        },
                        new
                        {
                            CustomerID = 2,
                            Budget = 30000m,
                            CustomerName = "Cem",
                            CustomerSurname = "Can",
                            CustomerType = 0,
                            Email = "ccan@gmail.com",
                            Password = "1",
                            TotalSpent = 2000m,
                            Username = "ccan"
                        },
                        new
                        {
                            CustomerID = 3,
                            Budget = 4000m,
                            CustomerName = "Ali",
                            CustomerSurname = "Veli",
                            CustomerType = 0,
                            Email = "aveli@gmail.com",
                            Password = "1",
                            TotalSpent = 1500m,
                            Username = "aveli"
                        },
                        new
                        {
                            CustomerID = 4,
                            Budget = 15000m,
                            CustomerName = "Kazım",
                            CustomerSurname = "Okka",
                            CustomerType = 1,
                            Email = "kokka@gmail.com",
                            Password = "1",
                            TotalSpent = 500m,
                            Username = "kokka"
                        },
                        new
                        {
                            CustomerID = 5,
                            Budget = 100000m,
                            CustomerName = "Cemil",
                            CustomerSurname = "Şükür",
                            CustomerType = 1,
                            Email = "csukur@gmail.com",
                            Password = "1",
                            TotalSpent = 150000m,
                            Username = "csukur"
                        });
                });

            modelBuilder.Entity("ABCMedical.Models.Entities.Log", b =>
                {
                    b.Property<int>("LogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LogID"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("CustomerType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("LogDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LogType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("PurchasedQuantity")
                        .HasColumnType("int");

                    b.Property<string>("TransactionResult")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("LogID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("OrderID");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("ABCMedical.Models.Entities.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ProductID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ABCMedical.Models.Entities.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            ProductName = "Laptop",
                            Stock = 50,
                            UnitPrice = 50000m
                        },
                        new
                        {
                            ProductID = 2,
                            ProductName = "IPhone 16 Plus",
                            Stock = 100,
                            UnitPrice = 90000m
                        },
                        new
                        {
                            ProductID = 3,
                            ProductName = "Swatch Saat",
                            Stock = 100,
                            UnitPrice = 5500m
                        },
                        new
                        {
                            ProductID = 4,
                            ProductName = "Logitech Mouse",
                            Stock = 100,
                            UnitPrice = 500m
                        },
                        new
                        {
                            ProductID = 5,
                            ProductName = "Hp Yazıcı",
                            Stock = 100,
                            UnitPrice = 6000m
                        },
                        new
                        {
                            ProductID = 6,
                            ProductName = "Arçelik Buzdolabı",
                            Stock = 100,
                            UnitPrice = 10000m
                        });
                });

            modelBuilder.Entity("ABCMedical.Models.Entities.Cart", b =>
                {
                    b.HasOne("ABCMedical.Models.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ABCMedical.Models.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ABCMedical.Models.Entities.Log", b =>
                {
                    b.HasOne("ABCMedical.Models.Entities.Customer", "Customer")
                        .WithMany("Logs")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ABCMedical.Models.Entities.Order", "Order")
                        .WithMany("Logs")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("ABCMedical.Models.Entities.Order", b =>
                {
                    b.HasOne("ABCMedical.Models.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ABCMedical.Models.Entities.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ABCMedical.Models.Entities.Customer", b =>
                {
                    b.Navigation("Logs");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ABCMedical.Models.Entities.Order", b =>
                {
                    b.Navigation("Logs");
                });

            modelBuilder.Entity("ABCMedical.Models.Entities.Product", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
