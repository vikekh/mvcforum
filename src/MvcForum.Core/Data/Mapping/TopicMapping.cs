namespace MvcForum.Core.Data.Mapping
{
    using DomainModel.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(450);
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.Solved).IsRequired();
            builder.Property(x => x.SolvedReminderSent);
            builder.Property(x => x.Slug).IsRequired().HasMaxLength(450);
            builder.Property(x => x.Views);
            builder.Property(x => x.IsSticky).IsRequired();
            builder.Property(x => x.IsLocked).IsRequired();
            builder.Property(x => x.Pending);
            builder.Property(x => x.LastPostId).HasColumnName("Post_Id");

            // FK
            builder.Property(x => x.PollId).HasColumnName("Poll_Id");
            builder.Property(x => x.CategoryId).IsRequired().HasColumnName("Category_Id");
            builder.Property(x => x.MembershipUserId).IsRequired().HasColumnName("MembershipUser_Id");

            // Indexes
            builder.HasIndex(x => x.Slug).HasName("IX_Topic_Name");
            builder.HasIndex(x => x.Slug).IsUnique().HasName("IX_Topic_Slug");

            // Relations
            builder.HasOne(t => t.Poll)
                .WithMany(x => x.Topics)
                .HasForeignKey(x => x.PollId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.Category)
                .WithMany(t => t.Topics)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.User)
                .WithMany(t => t.Topics)
                .HasForeignKey(x => x.MembershipUserId)
                .OnDelete(DeleteBehavior.Cascade);

            HasMany(x => x.Posts).WithRequired(x => x.Topic).Map(x => x.MapKey("Topic_Id")).WillCascadeOnDelete(false);

            HasMany(x => x.TopicNotifications).WithRequired(x => x.Topic).Map(x => x.MapKey("Topic_Id"))
                .WillCascadeOnDelete(false);
            HasMany(t => t.Tags)
                .WithMany(t => t.Topics)
                .Map(m =>
                {
                    m.ToTable("Topic_Tag");
                    m.MapLeftKey("Topic_Id");
                    m.MapRightKey("TopicTag_Id");
                });
        }
    }
}