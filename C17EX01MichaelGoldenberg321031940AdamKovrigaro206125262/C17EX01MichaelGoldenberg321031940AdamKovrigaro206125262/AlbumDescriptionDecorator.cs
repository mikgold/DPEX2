using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace DP.EX01
{
    public class AlbumDescriptionDecorator : BaseAlbumDecorator
    {       
        public AlbumDescriptionDecorator(Album i_album) : base(i_album)
        {
        }

        public AlbumDescriptionDecorator(BaseAlbumDecorator i_album) : base(i_album)
        {
        }

        public override string ToString()
        {
            return this.album.Name + string.Format("({0})", album.Count);
        }

        public string CreationTimeDescription()
        {
            return this.album.CreatedTime != null ? this.album.CreatedTime.Value.Date.ToShortDateString() : string.Empty;
        }
    }
}
