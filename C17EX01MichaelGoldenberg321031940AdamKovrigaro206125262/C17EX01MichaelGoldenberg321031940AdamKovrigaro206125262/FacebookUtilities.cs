using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace DP.EX01
{
    public static class FacebookUtilities
    {
        private static readonly string k_AppId = "1900996670165555";
        private static readonly string k_Secondary_AppId = "1450160541956417";

        private static User m_LoggedInUser;

        public static User LoggedInUser
        {
            get { return m_LoggedInUser; }
        }
        
        public static User LoginToFacebookApp(bool i_isPrimaryApp = true)
        {
            /// "user_groups" (This permission is only available for apps using Graph API version v2.3 or older.)
            /// "user_status" (This permission is only available for apps using Graph API version v2.3 or older.)
            /// "read_mailbox", (This permission is only available for apps using Graph API version v2.3 or older.)
            /// "read_stream", (This permission is only available for apps using Graph API version v2.3 or older.)
            /// "manage_notifications", (This permission is only available for apps using Graph API version v2.3 or older.)

            LoginResult result = FacebookService.Login(
                /// (desig patter's "Design Patterns Course App 2.4" app)
                i_isPrimaryApp ? k_AppId : k_Secondary_AppId,
                "public_profile",
               "user_education_history",
               "user_birthday",
               "user_actions.video",
               "user_actions.news",
               "user_actions.music",
               "user_actions.fitness",
               "user_actions.books",
               "user_about_me",
               "user_friends",
               "publish_actions",
               "user_events",
               "user_games_activity",               
               "user_hometown",
               "user_likes",
               "user_location",
               "user_managed_groups",
               "user_photos",
               "user_posts",
               "user_relationships",
               "user_relationship_details",
               "user_religion_politics",
               "user_tagged_places",
               "user_videos",
               "user_website",
               "user_work_history",
               "read_custom_friendlists",
               "read_page_mailboxes",
               "manage_pages",
               "publish_pages",
               "publish_actions",
               "rsvp_event");

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                return result.LoggedInUser;               
            }
            else
            {
                return null;
            }
        }

        public static void LogOut()
        {
            // log out only if there is a logged in user
            if (m_LoggedInUser != null)
            {
                FacebookService.Logout(() => { });
                m_LoggedInUser = null;
            }
        }

        private static IEnumerable<SomeType> PickSomeInRandomOrder<SomeType>(
            IEnumerable<SomeType> i_someTypes, int i_maxCount)
        {
            Random random = new Random(DateTime.Now.Millisecond);

            Dictionary<double, SomeType> randomSortTable = new Dictionary<double, SomeType>();

            foreach (SomeType someType in i_someTypes)
            {
                randomSortTable[random.NextDouble()] = someType;
            }

            return randomSortTable.OrderBy(KVP => KVP.Key).Take(i_maxCount).Select(KVP => KVP.Value);
        }

        public static IEnumerable<User> GetTenRandomFriends()
        {
            if (LoggedInUser.Friends.Count >= 10)
            {
                return PickSomeInRandomOrder(LoggedInUser.Friends, 10);
            }

            return null;
        }

        public static Dictionary<string, int> GetLikeStatistics()
        {
            Dictionary<string, int> likesDitcionary = new Dictionary<string, int>();

            foreach (Post post in LoggedInUser.Posts)
            {
                foreach (User userLike in post.LikedBy)
                {
                    if (!likesDitcionary.ContainsKey(userLike.Name))
                    {
                        likesDitcionary.Add(userLike.Name, 1);
                    }
                    else
                    {
                        likesDitcionary[userLike.Name] = likesDitcionary[userLike.Name] + 1;
                    }
                }
            }

            return likesDitcionary;
        }
    }
}
