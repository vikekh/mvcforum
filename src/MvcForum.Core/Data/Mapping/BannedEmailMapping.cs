namespace MvcForum.Core.Data.Mapping
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MVCForum.Domain.DomainModel;

    public class BannedEmailConfiguration : IEntityTypeConfiguration<BannedEmail>
    {
        public void Configure(EntityTypeBuilder<BannedEmail> builder)
        {
            builder.ToTable("BannedEmail");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Email).IsRequired().HasMaxLength(200);
            builder.Property(x => x.DateAdded).IsRequired();
        }
    }
}