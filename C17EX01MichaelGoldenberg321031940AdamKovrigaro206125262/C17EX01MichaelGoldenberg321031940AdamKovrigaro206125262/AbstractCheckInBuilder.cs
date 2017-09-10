using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace DP.EX01
{
    public abstract class AbstractCheckInBuilder
    {
        protected string m_placeId;
        protected string m_locationCoordinates;
        protected string m_message;
        protected string m_link;
        protected string m_picutreUrl;
        protected string m_taggedFriendsIds;

        public AbstractCheckInBuilder PlaceId(string i_placeId)
        {
            throw new NotImplementedException();
        }

        public AbstractCheckInBuilder LocationCoordinates(string i_locationCoordinates)
        {
            throw new NotImplementedException();
        }

        public AbstractCheckInBuilder Link(string i_link)
        {
            throw new NotImplementedException();
        }

        public AbstractCheckInBuilder Message(string i_message)
        {
            throw new NotImplementedException();
        }

        public AbstractCheckInBuilder PicutreUrl(string i_picutreUrl)
        {
            throw new NotImplementedException();
        }

        public AbstractCheckInBuilder TaggedFriendsNames(IEnumerable<string> i_taggedFriendsIds)
        {
            throw new NotImplementedException();
        }

        public FacebookWrapper.ObjectModel.Checkin Build()
        {
            throw new NotImplementedException();
        }        
    }
}
