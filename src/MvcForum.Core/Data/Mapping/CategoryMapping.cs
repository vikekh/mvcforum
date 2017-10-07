namespace MvcForum.Core.Data.Mapping
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MVCForum.Domain.DomainModel;

    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(450);
            builder.Property(x => x.Description);
            builder.Property(x => x.DateCreated).IsRequired();
            builder.Property(x => x.Slug).IsRequired().HasMaxLength(450);
            builder.Property(x => x.SortOrder).IsRequired();
            builder.Property(x => x.IsLocked).IsRequired();
            builder.Property(x => x.ModerateTopics).IsRequired();
            builder.Property(x => x.ModeratePosts).IsRequired();
            builder.Property(x => x.PageTitle).HasMaxLength(100);
            builder.Property(x => x.MetaDescription).HasMaxLength(250);
            builder.Property(x => x.Path).HasMaxLength(2500);
            builder.Property(x => x.Colour).HasMaxLength(50);
            builder.Property(x => x.Image).HasMaxLength(200);

            // FK
            builder.Property(x => x.CategoryId).HasColumnName("Category_Id");

            // Indexes
            builder.HasIndex(x => x.Slug).IsUnique().HasName("IX_Category_Slug");

            // Relations
            builder.HasOne(x => x.ParentCategory)
                .WithMany()
                .HasForeignKey(x => x.CategoryId);

            builder.HasMany(x => x.CategoryNotifications)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            // Ignores
            builder.Ignore(x => x.NiceUrl);
            builder.Ignore(x => x.Level);
        }
    }
}