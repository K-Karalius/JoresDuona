using JoresDuona.Server.Models.Order.Discount;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JoresDuona.Server.DbContext.EntityConfigurations;

public class OrderDiscountEntityConfiguration : IEntityTypeConfiguration<OrderDiscount>
{
    public void Configure(EntityTypeBuilder<OrderDiscount> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.HasOne(x => x.Order)
            .WithMany(x => x.OrderDiscounts)
            .HasForeignKey(x => x.OrderId);
        
        builder.HasOne(x => x.Discount)
            .WithMany(x => x.OrderDiscounts)
            .HasForeignKey(x => x.DiscountId);
    }
}