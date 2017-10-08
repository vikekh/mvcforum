namespace MvcForum.Core.Data.Mapping
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MVCForum.Domain.DomainModel;

    public class TopicNotificationConfiguration : IEntityTypeConfiguration<TopicNotification>
    {
        public void Configure(EntityTypeBuilder<TopicNotification> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            // FK


            // Relations
        }
    }
}