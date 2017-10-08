using MVCForum.Domain.DomainModel;

namespace MVCForum.Domain.Events
{
    using MvcForum.Core.DomainModel.Entities;

    public class FavouriteEventArgs : MVCForumEventArgs
    {
        public Favourite Favourite { get; set; }
    }
}
