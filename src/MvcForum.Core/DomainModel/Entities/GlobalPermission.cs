namespace MvcForum.Core.DomainModel.Entities
{
    using System;
    using MVCForum.Domain.DomainModel;
    using MVCForum.Utilities;

    public partial class GlobalPermissionForRole : Entity
    {
        public GlobalPermissionForRole()
        {
            Id = GuidComb.GenerateComb();
        }

        public Guid Id { get; set; }
        public bool IsTicked { get; set; }

        // FK
        public Guid PermissionId { get; set; }
        public Guid MembershipRoleId { get; set; }

        // Relations
        public virtual Permission Permission { get; set; }
        public virtual MembershipRole MembershipRole { get; set; }
    }
}
