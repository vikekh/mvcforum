using MVCForum.Domain.DomainModel;

namespace MVCForum.Domain.Events
{
    using MvcForum.Core.DomainModel.Entities;

    public class VoteEventArgs  : MVCForumEventArgs
    {
        public Vote Vote { get; set; }
    }
}
