using DomainLogic.Business.Specs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mijalski.EntityFrameworkCore.EntityTypeConfigurations
{
    public class RamEntityTypeConfiguration : IEntityTypeConfiguration<Ram>
    {
        public void Configure(EntityTypeBuilder<Ram> builder)
        {
            builder.ToTable("AppRams");
            builder.HasKey(_ => _.GraphicCardId);
        }
    }
}