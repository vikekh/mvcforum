namespace MvcForum.Core.Data.Context
{
    using DomainModel.Activity;
    using DomainModel.Entities;
    using ExtensionMethods.Data;
    using Microsoft.EntityFrameworkCore;
    using MVCForum.Domain.DomainModel;    
    using MVCForum.Domain.DomainModel.Entities;

    public class MvcForumContext : DbContext
    {
        public DbSet<Activity> Activity { get; set; }
        public DbSet<Badge> Badge { get; set; }
        public DbSet<Block> Block { get; set; }
        public DbSet<BadgeTypeTimeLastChecked> BadgeTypeTimeLastChecked { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<CategoryNotification> CategoryNotification { get; set; }
        public DbSet<CategoryPermissionForRole> CategoryPermissionForRole { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<LocaleResourceKey> LocaleResourceKey { get; set; }
        public DbSet<LocaleStringResource> LocaleStringResource { get; set; }
        public DbSet<MembershipRole> MembershipRole { get; set; }
        public DbSet<MembershipUser> MembershipUser { get; set; }
        public DbSet<MembershipUserPoints> MembershipUserPoints { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<Poll> Poll { get; set; }
        public DbSet<PollAnswer> PollAnswer { get; set; }
        public DbSet<PollVote> PollVote { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<PrivateMessage> PrivateMessage { get; set; }
        public DbSet<Settings> Setting { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<TopicNotification> TopicNotification { get; set; }
        public DbSet<TagNotification> TagNotification { get; set; }
        public DbSet<Vote> Vote { get; set; }
        public DbSet<TopicTag> TopicTag { get; set; }
        public DbSet<BannedEmail> BannedEmail { get; set; }
        public DbSet<BannedWord> BannedWord { get; set; }
        public DbSet<UploadedFile> UploadedFile { get; set; }
        public DbSet<Favourite> Favourite { get; set; }
        public DbSet<GlobalPermissionForRole> GlobalPermissionForRole { get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<PostEdit> PostEdit { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseEntityTypeConfiguration();
            base.OnModelCreating(modelBuilder);
        }
    }
}