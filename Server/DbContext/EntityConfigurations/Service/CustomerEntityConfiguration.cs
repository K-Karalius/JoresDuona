using JoresDuona.Server.Models.Service.Reservation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JoresDuona.Server.DbContext.EntityConfigurations;

public class CustomerEntityConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Phone).HasMaxLength(20);

        builder.HasMany(x => x.Reservations)
            .WithOne(x => x.Customer)
            .HasForeignKey(x => x.CustomerId);
    }
}