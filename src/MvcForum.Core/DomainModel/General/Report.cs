namespace MVCForum.Domain.DomainModel
{
    using MvcForum.Core.DomainModel.Entities;

    public partial class Report
    {
        public string Reason { get; set; }
        public virtual MembershipUser Reporter { get; set; }
        public virtual MembershipUser ReportedMember { get; set; }
        public virtual Post ReportedPost { get; set; }
    }
}
