namespace MvcForum.Core.DomainModel.Entities
{
    using System;
    using MVCForum.Domain.DomainModel;
    using MVCForum.Utilities;

    public partial class Favourite : Entity
    {
        public Favourite()
        {
            Id = GuidComb.GenerateComb();
        }
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }

        // FK
        public Guid MemberId { get; set; }
        public Guid? PostId { get; set; }
        public Guid? TopicId { get; set; }

        // Relations
        public virtual MembershipUser Member { get; set; }
        public virtual Post Post { get; set; }
        public virtual Topic Topic { get; set; }
    }
}
