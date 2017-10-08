namespace MvcForum.Core.Data.Mapping
{
    using DomainModel.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MVCForum.Domain.DomainModel;

    public class CategoryPermissionForRoleConfiguration : IEntityTypeConfiguration<CategoryPermissionForRole>
    {
        public void Configure(EntityTypeBuilder<CategoryPermissionForRole> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.IsTicked).IsRequired();

            // FK
            builder.Property(x => x.CategoryId).IsRequired().HasColumnName("Category_Id");
            builder.Property(x => x.PermissionId).IsRequired().HasColumnName("Permission_Id");
            builder.Property(x => x.MembershipRoleId).IsRequired().HasColumnName("MembershipRole_Id");

            // Relations
            builder.HasOne(x => x.Category)
                .WithMany(x => x.CategoryPermissionForRoles)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Permission)
                .WithMany(x => x.CategoryPermissionForRoles)
                .HasForeignKey(x => x.PermissionId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.MembershipRole)
                .WithMany(x => x.CategoryPermissionForRoles)
                .HasForeignKey(x => x.MembershipRoleId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}