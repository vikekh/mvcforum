namespace MvcForum.Core.DomainModel.Entities
{
    using System;
    using MVCForum.Domain.DomainModel;
    using MVCForum.Utilities;

    public partial class CategoryPermissionForRole : Entity
    {
        public CategoryPermissionForRole()
        {
            Id = GuidComb.GenerateComb();
        }
        public Guid Id { get; set; }
        public bool IsTicked { get; set; }

        // FK
        public Guid CategoryId { get; set; }
        public Guid PermissionId { get; set; }
        public Guid MembershipRoleId { get; set; }

        public virtual Permission Permission { get; set; }
        public virtual MembershipRole MembershipRole { get; set; }
        public virtual Category Category { get; set; }
    }
}
