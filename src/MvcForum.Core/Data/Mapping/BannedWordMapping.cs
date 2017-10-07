namespace MvcForum.Core.Data.Mapping
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MVCForum.Domain.DomainModel;

    public class BannedWordConfiguration : IEntityTypeConfiguration<BannedWord>
    {
        public void Configure(EntityTypeBuilder<BannedWord> builder)
        {
            builder.ToTable("BannedWord");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Word).IsRequired().HasMaxLength(75);
            builder.Property(x => x.DateAdded).IsRequired();
            builder.Property(x => x.IsStopWord);
        }
    }
}