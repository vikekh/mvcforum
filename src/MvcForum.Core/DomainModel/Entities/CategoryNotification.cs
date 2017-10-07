using System;
using MVCForum.Utilities;

namespace MVCForum.Domain.DomainModel
{
    public partial class CategoryNotification : Entity
    {
        public CategoryNotification()
        {
            Id = GuidComb.GenerateComb();
        }

        public Guid CategoryId { get; set; } 
        public Guid MembershipUserId { get; set; } 

        public Guid Id { get; set; }
        public virtual Category Category { get; set; }
        public virtual MembershipUser User { get; set; }
    }
}
