namespace MvcForum.Core.Data.Mapping
{
    using DomainModel.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.PostContent).IsRequired();
            builder.Property(x => x.DateCreated).IsRequired();
            builder.Property(x => x.VoteCount).IsRequired();
            builder.Property(x => x.DateEdited).IsRequired();
            builder.Property(x => x.IsSolution).IsRequired();
            builder.Property(x => x.IsTopicStarter);
            builder.Property(x => x.FlaggedAsSpam);
            builder.Property(x => x.IpAddress).HasMaxLength(50);
            builder.Property(x => x.Pending);
            builder.Property(x => x.SearchField);
            builder.Property(x => x.InReplyTo);

            // FK
            builder.Property(x => x.TopicId).IsRequired().HasColumnName("Topic_Id");
            builder.Property(x => x.MembershipUserId).IsRequired().HasColumnName("MembershipUser_Id");

            // Relations
            builder.HasMany(x => x.Votes)
                .WithOne(x => x.Post)
                .Map(x => x.MapKey("Post_Id"))
                .WillCascadeOnDelete(false);

            HasMany(x => x.PostEdits)
                .WithRequired(x => x.Post)
                .Map(x => x.MapKey("Post_Id"))
                .WillCascadeOnDelete(false);
            //ToTable("CustomTableName");
            //Property(t => t.TopicId).HasColumnName("Topic_Id");
        }
    }
}