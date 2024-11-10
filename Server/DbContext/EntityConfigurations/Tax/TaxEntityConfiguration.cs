using JoresDuona.Server.Models.Tax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JoresDuona.Server.DbContext.EntityConfigurations;

public class TaxEntityConfiguration : IEntityTypeConfiguration<Tax>
{
    public void Configure(EntityTypeBuilder<Tax> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.HasMany(x => x.OrderItemTaxes)
            .WithOne(x => x.Tax)
            .HasForeignKey(x => x.TaxId);
        
        builder.HasOne(x => x.Business)
            .WithMany(x => x.Taxes)
            .HasForeignKey(x => x.BusinessId);
    }
}