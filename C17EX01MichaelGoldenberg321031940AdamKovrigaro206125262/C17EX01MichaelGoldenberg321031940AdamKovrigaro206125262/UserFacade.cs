using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace DP.EX01
{
    public class UserFacade
    {
        public enum eFBObjectsTypes
        {
            Post,
            Friend,
            Event,
            CheckIn,
            Album
        }

        public string getFBObjectInfo(eFBObjectsTypes i_eType, object i_FBObject)
        {
            string FBObjectInfo = null;
            switch (i_eType)
            {
                case eFBObjectsTypes.Post:
                    FBObjectInfo = getPostInfo(i_FBObject);
                    break;
                case eFBObjectsTypes.Friend:
                    FBObjectInfo = getFriendInfo(i_FBObject);
                    break;
                case eFBObjectsTypes.Event:
                    FBObjectInfo = getEventInfo(i_FBObject);
                    break;
                case eFBObjectsTypes.CheckIn:
                    FBObjectInfo = getCheckInInfo(i_FBObject);
                    break;
                case eFBObjectsTypes.Album:
                    FBObjectInfo = getAlbumInfo(i_FBObject);
                    break;
                default:
                    FBObjectInfo = null;
                    break;
            }

            return FBObjectInfo;
        }

        private string getCheckInInfo(object i_CheckIn)
        {
            string checkInInfo = "Place: " + (i_CheckIn as Checkin).Place.Name + "\n";
                   checkInInfo += "Description: " + (i_CheckIn as Checkin).Place.Description;
            return checkInInfo;
        }

        private string getPostInfo(object i_Post)
        {
            string PostInfo = "Caption: " + (i_Post as Post).Caption + "\n" +
                                 "Message: " + (i_Post as Post).Message + "\n" +
                                 "Type:" + (i_Post as Post).Type;
            return PostInfo;
        }

        private string getFriendInfo(object i_Friend)
        {
            string FriendInfo = "ID: " + (i_Friend as User).Id + "\n" +
                                "Name: " + (i_Friend as User).Name + "\n" +
                                "Bio:" + (i_Friend as User).Bio;
            return FriendInfo;
        }

        private string getEventInfo(object i_Event)
        {
            string EventInfo = "Name: " + (i_Event as Event).Name + "\n" +
                               "Location: " + (i_Event as Event).Place.Name;
            return EventInfo;
        }

        private string getAlbumInfo(object i_Album)
        {
            string AlbumInfo = "Name: " + (i_Album as Album).Name + "\n" +
                               "Picture count: " + (i_Album as Album).Count.ToString() + "\n" +
                               "Creation time:" + (i_Album as Album).CreatedTime.ToString();
            return AlbumInfo;
        }
    }
}
