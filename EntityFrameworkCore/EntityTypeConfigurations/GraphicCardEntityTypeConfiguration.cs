using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mijalski.EntityFrameworkCore.Business.GraphicCards;

namespace Mijalski.EntityFrameworkCore.EntityTypeConfigurations
{
    public class GraphicCardEntityTypeConfiguration : IEntityTypeConfiguration<GraphicCard>
    {
        public void Configure(EntityTypeBuilder<GraphicCard> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.HasIndex(_ => _.Name);
            builder.HasOne(_ => _.Vendor).WithMany().HasForeignKey(_ => _.VendorId);
            builder.HasOne(_ => _.Ram).WithMany().HasPrincipalKey(_ => _.GraphicCardId);
            builder.ToTable("AppGraphicCards");
        }
    }
}