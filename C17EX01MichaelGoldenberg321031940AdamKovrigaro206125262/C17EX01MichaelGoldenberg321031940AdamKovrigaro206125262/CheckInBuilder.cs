using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace DP.EX01
{    
    public class CheckInBuilder : AbstractCheckInBuilder
    {        
        public CheckInBuilder PlaceId(string i_placeName)
        {   
            if (i_placeName != null)
            {
                this.m_placeId = CheckInPlaces.PlacesData[i_placeName];
            }
            
            return this;
        }

        public CheckInBuilder LocationCoordinates(string i_locationCoordinates)
        {
            this.m_locationCoordinates = i_locationCoordinates;
            return this;
        }

        public CheckInBuilder Link(string i_link)
        {
            this.m_link = i_link;
            return this;
        }

        public CheckInBuilder Message(string i_message)
        {
            this.m_message = i_message;
            return this;
        }

        public CheckInBuilder PicutreUrl(string i_picutreUrl)
        {
            // for some reasons and problems with facebook api permissions this didn't work
            // i leave it here to show the code that should be here
            this.m_picutreUrl = i_picutreUrl;

            this.m_picutreUrl = null;
            return this;
        }

        public CheckInBuilder TaggedFriendsNames(IEnumerable<string> i_taggedFriendsNames)
        {
            if (i_taggedFriendsNames != null && i_taggedFriendsNames.Count() > 0)
            {
                string strTaggedFriendsId = string.Empty;
                foreach (string name in i_taggedFriendsNames)
                {
                    User currentUser = FacebookUtilities.LoggedInUser.Friends.Find(new Predicate<FacebookWrapper.ObjectModel.User>((user) => user.Name == name));
                    strTaggedFriendsId += currentUser.Id + ",";
                }

                strTaggedFriendsId = strTaggedFriendsId.Substring(0, strTaggedFriendsId.Length - 1);
                this.m_taggedFriendsIds = strTaggedFriendsId;
            }
            
            return this;
        }

        public Checkin Build()
        {
            if (string.IsNullOrEmpty(this.m_placeId))
            {
                return null;
            }

            return FacebookUtilities.LoggedInUser.Checkin(m_placeId, m_locationCoordinates, m_message, m_link, m_picutreUrl, m_taggedFriendsIds);
        }
    }
}
