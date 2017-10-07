namespace MvcForum.Core.DomainModel.Entities
{
    using System;
    using MVCForum.Domain.DomainModel;
    using MVCForum.Utilities;

    public class Block : Entity
    {
        public Block()
        {
            Id = GuidComb.GenerateComb();
        }
        public Guid Id { get; set; }

        //  FK
        public Guid BlockerId { get; set; }
        public Guid BlockedId { get; set; }

        public MembershipUser Blocker { get; set; }
        public MembershipUser Blocked { get; set; }
        public DateTime Date { get; set; }
    }
}
