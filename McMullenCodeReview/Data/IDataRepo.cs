using McMullenCodeReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace McMullenCodeReview.Data
{
    public interface IDataRepo
    {
        IEnumerable<AlbumModel> GetAlbums();
        IEnumerable<PhotoModel> GetPhotosByAlbumId(int AlbumID);
    }
}
