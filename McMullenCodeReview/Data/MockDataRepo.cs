using McMullenCodeReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace McMullenCodeReview.Data
{
    public class MockDataRepo : IDataRepo
    {
        public IEnumerable<AlbumModel> GetAlbums()
        {
            var albums = new List<AlbumModel>
            {
                new AlbumModel{UserId=12, Id=1, Title="Test Pictures" },
                new AlbumModel{UserId=12, Id=2, Title="Test Album 2" },
            };
            return albums;
        }

        public IEnumerable<PhotoModel> GetPhotosByAlbumId(int AlbumID)
        {
            var photos = new List<PhotoModel>
            { 
               new PhotoModel{ AlbumID=1, Id=1, Title="Photo 1",Url = "https://via.placeholder.com/600/92c952", thumbnailUrl="https://via.placeholder.com/150/92c952"},
               new PhotoModel{ AlbumID=1, Id=2, Title="Photo 2",Url = "https://via.placeholder.com/600/771796", thumbnailUrl="https://via.placeholder.com/150/771796"},
               new PhotoModel{ AlbumID=1, Id=3, Title="Photo 3",Url = "https://via.placeholder.com/600/24f355", thumbnailUrl="https://via.placeholder.com/150/24f355"}
            };
            throw new NotImplementedException();
        }
    }
}