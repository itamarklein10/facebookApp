using System.Collections.Generic;
using System.Collections;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace project1
{
    internal class PhotosIterator : IEnumerable, IEnumerable<string>
    {
        private readonly FacebookObjectCollection<Album> r_AllPhotos;

        public PhotosIterator(FacebookObjectCollection<Album> i_AllPhotos)
        {
            r_AllPhotos = i_AllPhotos;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (Album album in r_AllPhotos)
            {
                foreach (Photo photo in album.Photos)
                {
                    yield return photo.PictureThumbURL;
                }
            }
        }

        //public IEnumerator<string> GetEnumerator()
        //{
        //    return (from album in r_AllPhotos
        //            from photo in album.Photos
        //            select photo.PictureThumbURL)
        //            .GetEnumerator();
        //}
    }
}
