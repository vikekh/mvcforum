using MVCForum.Domain.DomainModel;

namespace MVCForum.Domain.Events
{
    using MvcForum.Core.DomainModel.Entities;

    public class TopicMadeEventArgs : MVCForumEventArgs
    {
        public Topic Topic { get; set; }
    }
}
