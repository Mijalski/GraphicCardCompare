using Microsoft.EntityFrameworkCore;
using Mijalski.EntityFrameworkCore.Business.GraphicCards;
using Mijalski.EntityFrameworkCore.Business.Specs;
using Mijalski.EntityFrameworkCore.Business.Vendors;
using Mijalski.EntityFrameworkCore.EntityTypeConfigurations;

namespace Mijalski.EntityFrameworkCore
{
    public class DatabaseContext : DbContext
    {
        public DbSet<GraphicCard> GraphicCards { get; set; }
        public DbSet<Ram> Rams { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GraphicCardEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RamEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new VendorEntityTypeConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
