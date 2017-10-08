using MVCForum.Domain.DomainModel;

namespace MVCForum.Domain.Events
{
    using MvcForum.Core.DomainModel.Entities;

    public class PostMadeEventArgs : MVCForumEventArgs
    {
        public Post Post { get; set; }
    }
}
