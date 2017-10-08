namespace MvcForum.Core.DomainModel.Entities
{
    using System;
    using MVCForum.Domain.DomainModel;
    using MVCForum.Utilities;

    public partial class Vote : Entity
    {
        public Vote()
        {
            Id = GuidComb.GenerateComb();
        }
        public Guid Id { get; set; }
        public int Amount { get; set; }
        public DateTime? DateVoted { get; set; }

        // FK
        public Guid? MembershipUserId { get; set; }
        public Guid? PostId { get; set; }
        public Guid VotedByMembershipUserId { get; set; }

        // Relations
        public virtual MembershipUser User { get; set; }
        public virtual Post Post { get; set; }
        public virtual MembershipUser VotedByMembershipUser { get; set; }
    }
}
