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
    [Migration("20200109202552_Initital")]
    partial class Initital
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

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcessorSpeed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VendorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("VendorId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Wattage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.HasIndex("VendorId");

                    b.HasIndex("VendorId1");

                    b.ToTable("AppGraphicCards");
                });

            modelBuilder.Entity("Mijalski.EntityFrameworkCore.Business.Specs.Ram", b =>
                {
                    b.Property<Guid>("GraphicCardId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RamSize")
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
                });

            modelBuilder.Entity("Mijalski.EntityFrameworkCore.Business.GraphicCards.GraphicCard", b =>
                {
                    b.HasOne("Mijalski.EntityFrameworkCore.Business.Vendors.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mijalski.EntityFrameworkCore.Business.Vendors.Vendor", null)
                        .WithMany("GraphicCards")
                        .HasForeignKey("VendorId1");
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
