using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using FacebookWrapper.ObjectModel;

namespace DP.EX01
{
    public abstract class BaseAlbumDecorator : IAlbum, IEnumerable<Photo>
    {
        protected Album album;        

        public BaseAlbumDecorator(Album i_album)
        {
            this.album = i_album;
        }

        public BaseAlbumDecorator(BaseAlbumDecorator i_album)
        {
            this.album = i_album.album;
        }

        public long? Count
        {
            get
            {
                return album.Count;
            }
        }

        public Photo CoverPhoto
        {
            get
            {
                return album.CoverPhoto;
            }
        }

        public string CoverPhotoID
        {
            get
            {
                return album.CoverPhotoID;
            }
        }

        public string CoverPhotoLargeURL
        {
            get
            {
                return album.CoverPhotoLargeURL;
            }
        }

        public string CoverPhotoThumbURL
        {
            get
            {
                return album.CoverPhotoThumbURL;
            }
        }

        public string Description
        {
            get
            {
                return album.Description;
            }
        }

        public Image ImageAlbum
        {
            get
            {
                return album.ImageAlbum;
            }
        }

        public Image ImageSmall
        {
            get
            {
                return album.ImageSmall;
            }
        }

        public Image ImageThumb
        {
            get
            {
                return album.ImageThumb;
            }
        }

        public string Link
        {
            get
            {
                return album.Link;
            }
        }

        public string Location
        {
            get
            {
                return album.Location;
            }
        }

        public string Name
        {
            get
            {
                return album.Name;
            }

            set
            {
                album.Name = value;
            }
        }

        public FacebookObjectCollection<Photo> Photos
        {
            get
            {
                return album.Photos;
            }
        }

        public string PictureAlbumURL
        {
            get
            {
                return album.PictureAlbumURL;
            }
        }

        public PicturesColleciton Pictures
        {
            get
            {
                return album.Pictures;
            }
        }

        public string PictureSmallURL
        {
            get
            {
                return album.PictureSmallURL;
            }
        }

        public string PictureThumbURL
        {
            get
            {
                return album.PictureThumbURL;
            }
        }

        public string PrivcaySettings
        {
            get
            {
                return album.PrivcaySettings;
            }
        }

        public Album.eType Type
        {
            get
            {
                return album.Type;
            }
        }

        public DateTime? UpdateTime
        {
            get
            {
                return album.UpdateTime;
            }
        }        

        public Photo UploadPhoto(string i_PictureFilePath, string i_Title = null, string i_Caption = null)
        {
            return album.UploadPhoto(i_PictureFilePath, i_Title, i_Caption);
        }

        public Photo UploadPhoto(byte[] i_PhotoData, string i_Title = null, string i_Caption = null, string i_FileName = "photo.jpg")
        {
            return album.UploadPhoto(i_PhotoData, i_Title, i_Caption, i_FileName);
        }

        public IEnumerator<Photo> GetEnumerator()
        {
            return this.album.Photos.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.album.Photos.GetEnumerator();
        }
    }
}
