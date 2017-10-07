namespace MvcForum.Core.Data.Mapping
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MVCForum.Domain.DomainModel;

    public class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.ToTable("Badge");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Description);
            builder.Property(x => x.Type).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Image).HasMaxLength(50);
            builder.Property(x => x.DisplayName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.AwardsPoints);
            builder.Ignore(x => x.Milestone);
        }
    }
}