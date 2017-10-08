namespace MvcForum.Core.Data.Mapping
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MVCForum.Domain.DomainModel;

    public class MembershipRoleConfiguration : IEntityTypeConfiguration<MembershipRole>
    {
        public void Configure(EntityTypeBuilder<MembershipRole> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.RoleName).IsRequired().HasMaxLength(256);
        }
    }
}