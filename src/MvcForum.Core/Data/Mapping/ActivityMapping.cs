namespace MvcForum.Core.Data.Mapping
{
    using DomainModel.Activity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ActivityConfiguration : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("Activity");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Timestamp).IsRequired();
            builder.Property(x => x.Data).IsRequired();
            builder.Property(x => x.Type).IsRequired().HasMaxLength(50);
        }
    }
}