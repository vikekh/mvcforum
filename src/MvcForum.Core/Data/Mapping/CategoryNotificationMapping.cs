namespace MvcForum.Core.Data.Mapping
{
    using DomainModel.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MVCForum.Domain.DomainModel;

    public class CategoryNotificationConfiguration : IEntityTypeConfiguration<CategoryNotification>
    {
        public void Configure(EntityTypeBuilder<CategoryNotification> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.Property(x => x.CategoryId).IsRequired().HasColumnName("Category_Id");
            builder.Property(x => x.MembershipUserId).IsRequired().HasColumnName("MembershipUser_Id");
        }
    }
}