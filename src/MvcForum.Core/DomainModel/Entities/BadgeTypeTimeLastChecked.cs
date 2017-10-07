namespace MvcForum.Core.DomainModel.Entities
{
    using System;
    using MVCForum.Domain.DomainModel;
    using MVCForum.Utilities;

    public class BadgeTypeTimeLastChecked : Entity
    {
        public BadgeTypeTimeLastChecked()
        {
            Id = GuidComb.GenerateComb();
        }

        public Guid Id { get; set; }
        public string BadgeType { get; set; }
        public DateTime TimeLastChecked { get; set; }

        // FK
        public Guid MembershipUserId { get; set; }

        public MembershipUser User { get; set; }
    }
}