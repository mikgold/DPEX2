using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace DP.EX01
{
    public class LikesInAlbumCounterDecorator : BaseAlbumDecorator
    {
        private int getLikes()
        {
            int likesCount = 0;
            foreach (var photo in this)
            {
                likesCount += photo.LikedBy.Count;
            }

            return likesCount;
        }

        public int LikesCount
        {
            get
            {                
                return getLikes();
            }
        }

        public LikesInAlbumCounterDecorator(Album i_album) : base(i_album)
        {
        }

        public LikesInAlbumCounterDecorator(BaseAlbumDecorator i_album) : base(i_album)
        {
        }

        public Photo MostLikedPhoto()
        {
            return this.OrderByDescending(photo => photo.LikedBy.Count).First();
        }        
    }
}
