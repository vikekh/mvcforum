namespace MvcForum.Core.Data.Mapping
{
    using DomainModel.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class BlockConfiguration : IEntityTypeConfiguration<Block>
    {
        public void Configure(EntityTypeBuilder<Block> builder)
        {
            builder.ToTable("Block");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Date).IsRequired();

            // FK mapping
            builder.Property(x => x.BlockerId).IsRequired().HasColumnName("Blocker_Id");
            builder.Property(x => x.BlockedId).IsRequired().HasColumnName("Blocked_Id");

            builder.HasOne(x => x.Blocker)
                .WithMany(x => x.BlockedUsers)
                .HasForeignKey(x => x.BlockerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Blocked)
                .WithMany(x => x.BlockedByOtherUsers)
                .HasForeignKey(x => x.BlockedId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}