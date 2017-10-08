namespace MVCForum.Domain.DomainModel.General
{
    using MvcForum.Core.DomainModel.Entities;

    public class MarkAsSolutionReminder
    {
        public Topic Topic { get; set; }
        public int PostCount { get; set; }
    }
}
