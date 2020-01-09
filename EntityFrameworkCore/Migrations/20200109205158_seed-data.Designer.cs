﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mijalski.EntityFrameworkCore;

namespace Mijalski.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200109205158_seed-data")]
    partial class seeddata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mijalski.EntityFrameworkCore.Business.GraphicCards.GraphicCard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("InterfaceType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProcessorSpeed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VendorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Wattage")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.HasIndex("VendorId");

                    b.ToTable("AppGraphicCards");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c12a6777-70fc-476b-b59b-58ad754fb7ec"),
                            CreationDateTime = new DateTime(2020, 1, 9, 20, 51, 58, 166, DateTimeKind.Utc).AddTicks(8127),
                            InterfaceType = "PCI Express 3.0",
                            Name = "GTX 970",
                            Price = 330m,
                            ProcessorSpeed = "1753MHz",
                            VendorId = new Guid("5266b65c-706e-46a5-a44c-74848cf085f0"),
                            Wattage = 145.0
                        },
                        new
                        {
                            Id = new Guid("cf92d8b9-4bc9-4c2e-8a9c-ac8df80c7c9e"),
                            CreationDateTime = new DateTime(2020, 1, 9, 20, 51, 58, 167, DateTimeKind.Utc).AddTicks(3226),
                            InterfaceType = "PCI Express 3.0",
                            Name = "RTX 2070 Super",
                            Price = 609m,
                            ProcessorSpeed = "1605Mhz + Boost",
                            VendorId = new Guid("5266b65c-706e-46a5-a44c-74848cf085f0"),
                            Wattage = 160.0
                        });
                });

            modelBuilder.Entity("Mijalski.EntityFrameworkCore.Business.Specs.Ram", b =>
                {
                    b.Property<Guid>("GraphicCardId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfRam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GraphicCardId");

                    b.ToTable("AppRams");
                });

            modelBuilder.Entity("Mijalski.EntityFrameworkCore.Business.Vendors.Vendor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("AppVendors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5266b65c-706e-46a5-a44c-74848cf085f0"),
                            CreationDateTime = new DateTime(2020, 1, 9, 20, 51, 58, 166, DateTimeKind.Utc).AddTicks(3409),
                            Name = "Nvidia"
                        });
                });

            modelBuilder.Entity("Mijalski.EntityFrameworkCore.Business.GraphicCards.GraphicCard", b =>
                {
                    b.HasOne("Mijalski.EntityFrameworkCore.Business.Vendors.Vendor", "Vendor")
                        .WithMany("GraphicCards")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Mijalski.EntityFrameworkCore.Business.Specs.Ram", b =>
                {
                    b.HasOne("Mijalski.EntityFrameworkCore.Business.GraphicCards.GraphicCard", null)
                        .WithOne("Ram")
                        .HasForeignKey("Mijalski.EntityFrameworkCore.Business.Specs.Ram", "GraphicCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}