﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(warehouseContext))]
    partial class warehouseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Burritoo");

                    b.Property<string>("Category")
                        .HasColumnName("category")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("ItemName")
                        .HasColumnName("item_name")
                        .HasMaxLength(80)
                        .IsUnicode(false);

                    b.Property<string>("Manufacturer")
                        .HasColumnName("manufacturer")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Size")
                        .HasColumnName("size")
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.Property<double?>("UnitPrice")
                        .HasColumnName("unit_price");

                    b.HasKey("Id");

                    b.ToTable("warehouse");
                });
#pragma warning restore 612, 618
        }
    }
}