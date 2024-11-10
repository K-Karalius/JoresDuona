using JoresDuona.Server.Models.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JoresDuona.Server.DbContext.EntityConfigurations;

public class OrderServiceEntityConfiguration : IEntityTypeConfiguration<OrderService>
{
    public void Configure(EntityTypeBuilder<OrderService> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        
        builder.HasOne(x => x.Service)
            .WithMany(x => x.OrderServices)
            .HasForeignKey(x => x.ServiceId);
        
        builder.HasOne(x => x.Order)
            .WithMany(x => x.OrderServices)
            .HasForeignKey(x => x.OrderId);
    }
}