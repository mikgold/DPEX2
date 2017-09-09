using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace DP.EX01
{
    class CheckInBuilder : ICheckInBuilder
    {
        protected string m_placeId;
        protected string m_locationCoordinates;
        protected string m_message;
        protected string m_link;
        protected string m_picutreUrl;
        protected string m_taggedFriendsIds;
        private static Dictionary<string, string> places = new Dictionary<string, string>() {
            {"קניון עזריאלי","160830340635663"},
            {"קניון גבעתיים","358198677205"},
            {"הקניון הגדול","107809162598134"},
            {"האקדמית תא יפו","172690942762150"}            
        };

        public ICheckInBuilder PlaceId(string i_placeName)
        {            
            this.m_placeId = places[i_placeName];
            return this;
        }

        public ICheckInBuilder LocationCoordinates(string i_locationCoordinates)
        {
            this.m_locationCoordinates = i_locationCoordinates;
            return this;
        }

        public ICheckInBuilder Link(string i_link)
        {
            this.m_link = i_link;
            return this;
        }

        public ICheckInBuilder Message(string i_message)
        {
            this.m_message = i_message;
            return this;
        }

        public ICheckInBuilder PicutreUrl(string i_picutreUrl)
        {
            // for some reasons and problems with facebook api permissions this didn't work
            // i leave it here to show the code that should be here
            this.m_picutreUrl = i_picutreUrl;

            this.m_picutreUrl = null;
            return this;
        }

        public ICheckInBuilder TaggedFriendsNames(IEnumerable<string> i_taggedFriendsNames)
        {
            string strTaggedFriendsId = "";

            foreach (string name in i_taggedFriendsNames)
            {
                User currentUser = FacebookUtilities.LoggedInUser.Friends.Find(new Predicate<FacebookWrapper.ObjectModel.User>((user) => user.Name == name));
                strTaggedFriendsId += currentUser.Id + ",";
            }

            strTaggedFriendsId = strTaggedFriendsId.Substring(0, strTaggedFriendsId.Length - 1);

            this.m_taggedFriendsIds = strTaggedFriendsId;
            return this;
        }

        public Checkin Build()
        {
            var a = 1;
            return FacebookUtilities.LoggedInUser.Checkin(m_placeId, m_locationCoordinates, m_message, m_link, m_picutreUrl, m_taggedFriendsIds);
        }
    }
}
