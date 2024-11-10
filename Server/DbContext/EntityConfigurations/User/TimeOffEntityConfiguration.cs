using JoresDuona.Server.Models.TimeOff;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JoresDuona.Server.DbContext.EntityConfigurations;

public class TimeOffEntityConfiguration : IEntityTypeConfiguration<TimeOff>
{
    public void Configure(EntityTypeBuilder<TimeOff> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        
        builder.HasOne(x => x.User)
            .WithMany(x => x.TimeOffs)
            .HasForeignKey(x => x.UserId);
    }
}