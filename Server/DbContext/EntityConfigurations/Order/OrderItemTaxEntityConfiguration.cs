using JoresDuona.Server.Models.Order.Items.Tax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JoresDuona.Server.DbContext.EntityConfigurations;

public class OrderItemTaxEntityConfiguration : IEntityTypeConfiguration<OrderItemTax>
{
    public void Configure(EntityTypeBuilder<OrderItemTax> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.HasOne(x => x.OrderItem)
            .WithMany(x => x.OrderItemTaxes)
            .HasForeignKey(x => x.OrderItemId);
        
        builder.HasOne(x => x.Tax)
            .WithMany(x => x.OrderItemTaxes)
            .HasForeignKey(x => x.TaxId);
    }
}