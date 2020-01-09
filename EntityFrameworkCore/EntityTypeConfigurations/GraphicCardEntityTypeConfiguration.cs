using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mijalski.EntityFrameworkCore.Business.GraphicCards;
using Mijalski.EntityFrameworkCore.Business.Specs;

namespace Mijalski.EntityFrameworkCore.EntityTypeConfigurations
{
    public class GraphicCardEntityTypeConfiguration : IEntityTypeConfiguration<GraphicCard>
    {
        public void Configure(EntityTypeBuilder<GraphicCard> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.HasIndex(_ => _.Name);
            builder.HasOne(_ => _.Vendor).WithMany(_ => _.GraphicCards).HasForeignKey(_ => _.VendorId);
            builder.HasOne(_ => _.Ram).WithOne().HasForeignKey<Ram>(_ => _.GraphicCardId);
            builder.ToTable("AppGraphicCards");
        }
    }
}