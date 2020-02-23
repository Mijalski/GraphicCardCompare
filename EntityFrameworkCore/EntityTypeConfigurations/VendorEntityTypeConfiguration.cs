using DomainLogic.Business.Vendors;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mijalski.EntityFrameworkCore.EntityTypeConfigurations
{
    public class VendorEntityTypeConfiguration : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.HasIndex(_ => _.Name);
            builder.ToTable("AppVendors");
        }
    }
}