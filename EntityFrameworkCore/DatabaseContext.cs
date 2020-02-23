using System;
using DomainLogic.Business.GraphicCards;
using DomainLogic.Business.Specs;
using DomainLogic.Business.Vendors;
using Microsoft.EntityFrameworkCore;
using Mijalski.EntityFrameworkCore.EntityTypeConfigurations;

namespace Mijalski.EntityFrameworkCore
{
    public class DatabaseContext : DbContext
    {
        public DbSet<GraphicCard> GraphicCards { get; set; }
        public DbSet<Ram> Rams { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GraphicCardEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RamEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new VendorEntityTypeConfiguration());

            #region seed-data
            
            var nvidiaVendor = new Vendor
            {
                Name = "Nvidia"
            };
            var amdVendor = new Vendor
            {
                Name = "AMD"
            };
            var gtx970 = new GraphicCard
            {
                Name = "GTX 970",
                Price = 330,
                ProcessorSpeed = "1753MHz",
                Wattage = 145,
                InterfaceType = "PCI Express 3.0",
                VendorId = nvidiaVendor.Id
            };
            var rtx2070 = new GraphicCard
            {
                Name = "RTX 2070 Super",
                Price = 609,
                ProcessorSpeed = "1605Mhz + Boost",
                Wattage = 160,
                InterfaceType = "PCI Express 3.0",
                VendorId = nvidiaVendor.Id
            };
            var gtx970Ram = new Ram
            {
                Capacity = 4,
                TypeOfRam = "GDDR5",
                GraphicCardId = gtx970.Id
            };
            var rtx2070Ram = new Ram
            {
                Capacity = 8,
                TypeOfRam = "GDDR5",
                GraphicCardId = rtx2070.Id
            };

            #endregion

            modelBuilder.Entity<Vendor>().HasData(
                nvidiaVendor,amdVendor
            );
            modelBuilder.Entity<GraphicCard>().HasData(
                gtx970,rtx2070
            );
            modelBuilder.Entity<Ram>().HasData(
                gtx970Ram,rtx2070Ram
            );

            base.OnModelCreating(modelBuilder);
        }

    }
}
