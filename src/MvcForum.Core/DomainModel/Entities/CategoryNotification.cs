namespace MvcForum.Core.DomainModel.Entities
{
    using System;
    using MVCForum.Domain.DomainModel;
    using MVCForum.Utilities;

    public partial class CategoryNotification : Entity
    {
        public CategoryNotification()
        {
            Id = GuidComb.GenerateComb();
        }
        public Guid Id { get; set; }

        // FK
        public Guid CategoryId { get; set; } 
        public Guid MembershipUserId { get; set; } 

        // Relations
        public virtual Category Category { get; set; }
        public virtual MembershipUser User { get; set; }
    }
}
