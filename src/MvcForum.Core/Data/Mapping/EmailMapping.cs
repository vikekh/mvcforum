namespace MvcForum.Core.Data.Mapping
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MVCForum.Domain.DomainModel;

    public class EmailConfiguration : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.EmailTo).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Body).IsRequired();
            builder.Property(x => x.Subject).IsRequired().HasMaxLength(200);
            builder.Property(x => x.NameTo).IsRequired().HasMaxLength(100);
            builder.Property(x => x.DateCreated).IsRequired();
        }
    }
}