namespace MvcForum.Core.Data.Mapping
{
    using DomainModel.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class BadgeTypeTimeLastCheckedConfiguration : IEntityTypeConfiguration<BadgeTypeTimeLastChecked>
    {
        public void Configure(EntityTypeBuilder<BadgeTypeTimeLastChecked> builder)
        {
            builder.ToTable("BadgeTypeTimeLastChecked");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.BadgeType).IsRequired().HasMaxLength(50);
            builder.Property(x => x.TimeLastChecked).IsRequired();

            // Set the FK and the correct column name
            builder.Property(x => x.MembershipUserId).IsRequired().HasColumnName("MembershipUser_Id");

            builder.HasOne(t => t.User)
                .WithMany(t => t.BadgeTypesTimeLastChecked)
                .HasForeignKey(p => p.MembershipUserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}