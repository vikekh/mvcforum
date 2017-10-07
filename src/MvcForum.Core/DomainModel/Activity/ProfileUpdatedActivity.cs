namespace MVCForum.Domain.DomainModel.Activity
{
    using System;
    using MvcForum.Core.DomainModel.Activity;
    using MvcForum.Core.DomainModel.Enums;

    public class ProfileUpdatedActivity : ActivityBase
    {
        public const string KeyUserId = @"UserID";

        /// <summary>
        ///     Constructor - useful when constructing a badge activity after reading database
        /// </summary>
        public ProfileUpdatedActivity(Activity activity, MembershipUser user)
        {
            ActivityMapped = activity;
            User = user;
        }

        public MembershipUser User { get; set; }

        public static Activity GenerateMappedRecord(MembershipUser user, DateTime modified)
        {
            return new Activity
            {
                Data = KeyUserId + Equality + user.Id,
                Timestamp = modified,
                Type = ActivityType.ProfileUpdated.ToString()
            };
        }
    }
}