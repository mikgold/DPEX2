using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace DP.EX01
{
    interface ICheckInBuilder
    {
        ICheckInBuilder PlaceId(string i_placeId);
        ICheckInBuilder LocationCoordinates(string i_locationCoordinates);
        ICheckInBuilder Link(string i_link);
        ICheckInBuilder Message(string i_message);
        ICheckInBuilder PicutreUrl(string i_picutreUrl);
        ICheckInBuilder TaggedFriendsNames(IEnumerable<string> i_taggedFriendsIds);        
        FacebookWrapper.ObjectModel.Checkin Build();        
    }
}
