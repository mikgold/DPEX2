using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace DP.EX01
{
    public interface IAlbum
    {
        long? Count { get; }

        Photo CoverPhoto { get; }

        string CoverPhotoID { get; }

        string CoverPhotoLargeURL { get; }

        string CoverPhotoThumbURL { get; }

        string Description { get; }

        Image ImageAlbum { get; }

        Image ImageSmall { get; }

        Image ImageThumb { get; }

        string Link { get; }

        string Location { get; }

        string Name { get; set; }

        FacebookObjectCollection<Photo> Photos { get; }

        string PictureAlbumURL { get; }

        PicturesColleciton Pictures { get; }

        string PictureSmallURL { get; }

        string PictureThumbURL { get; }

        string PrivcaySettings { get; }

        Album.eType Type { get; }

        DateTime? UpdateTime { get; }

        Photo UploadPhoto(string i_PictureFilePath, string i_Title = null, string i_Caption = null);

        Photo UploadPhoto(byte[] i_PhotoData, string i_Title = null, string i_Caption = null, string i_FileName = "photo.jpg");        
    }
}
