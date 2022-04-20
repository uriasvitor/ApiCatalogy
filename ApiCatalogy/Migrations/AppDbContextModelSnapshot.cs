﻿// <auto-generated />
using System;
using ApiCatalogy.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiCatalogy.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ApiCatalogy.Category.Categorys", b =>
                {
                    b.Property<int>("CategorysId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("CategorysId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("ApiCatalogy.Category.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CategorysId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateSignin")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<float>("Estock")
                        .HasColumnType("float");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategorysId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ApiCatalogy.Category.Product", b =>
                {
                    b.HasOne("ApiCatalogy.Category.Categorys", "Category")
                        .WithMany("products")
                        .HasForeignKey("CategorysId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ApiCatalogy.Category.Categorys", b =>
                {
                    b.Navigation("products");
                });
#pragma warning restore 612, 618
        }
    }
}
