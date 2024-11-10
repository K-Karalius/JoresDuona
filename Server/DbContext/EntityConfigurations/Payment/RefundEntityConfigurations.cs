using JoresDuona.Server.Models.Payment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JoresDuona.Server.DbContext.EntityConfigurations;

public class RefundEntityConfigurations : IEntityTypeConfiguration<Refund>
{
    public void Configure(EntityTypeBuilder<Refund> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.RefundDate).HasDefaultValue(DateTime.UtcNow);

        builder.HasOne(x => x.Payment)
            .WithMany(x => x.Refunds)
            .HasForeignKey(x => x.PaymentId);
    }
}