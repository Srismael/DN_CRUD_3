﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Store.DataAccess;

#nullable disable

namespace Store.DataAccess.Migrations
{
    [DbContext(typeof(StoreDataContext))]
    partial class StoreDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Store.Core.Inventories.brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("brands");
                });

            modelBuilder.Entity("Store.Core.Inventories.category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("Store.Core.Inventories.product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("BrandIdId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryIdId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandIdId");

                    b.HasIndex("CategoryIdId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("Store.Core.Sale.sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("status")
                        .HasColumnType("longtext");

                    b.Property<int?>("userIDId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userIDId");

                    b.ToTable("sales");
                });

            modelBuilder.Entity("Store.Core.Sale.sale_detail", b =>
                {
                    b.Property<int>("Id_product")
                        .HasColumnType("int");

                    b.Property<int>("Id_sale")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<decimal>("discount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int?>("productId")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<int?>("saleId")
                        .HasColumnType("int");

                    b.HasKey("Id_product", "Id_sale");

                    b.HasIndex("productId");

                    b.HasIndex("saleId");

                    b.ToTable("salesdetail");
                });

            modelBuilder.Entity("Store.Core.User.user", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Store.Core.Inventories.product", b =>
                {
                    b.HasOne("Store.Core.Inventories.brand", "BrandId")
                        .WithMany("poducts")
                        .HasForeignKey("BrandIdId");

                    b.HasOne("Store.Core.Inventories.category", "CategoryId")
                        .WithMany("Products")
                        .HasForeignKey("CategoryIdId");

                    b.Navigation("BrandId");

                    b.Navigation("CategoryId");
                });

            modelBuilder.Entity("Store.Core.Sale.sale", b =>
                {
                    b.HasOne("Store.Core.User.user", "userID")
                        .WithMany("sales")
                        .HasForeignKey("userIDId");

                    b.Navigation("userID");
                });

            modelBuilder.Entity("Store.Core.Sale.sale_detail", b =>
                {
                    b.HasOne("Store.Core.Inventories.product", "product")
                        .WithMany()
                        .HasForeignKey("productId");

                    b.HasOne("Store.Core.Sale.sale", "sale")
                        .WithMany()
                        .HasForeignKey("saleId");

                    b.Navigation("product");

                    b.Navigation("sale");
                });

            modelBuilder.Entity("Store.Core.Inventories.brand", b =>
                {
                    b.Navigation("poducts");
                });

            modelBuilder.Entity("Store.Core.Inventories.category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Store.Core.User.user", b =>
                {
                    b.Navigation("sales");
                });
#pragma warning restore 612, 618
        }
    }
}