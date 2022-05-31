using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using McMullenCodeReview.Data;
using McMullenCodeReview.Models;
using Microsoft.AspNetCore.Mvc;

namespace McMullenCodeReview.Controllers
{
    public class AlbumsController : Controller
    {
        //private readonly IDataRepo _data;
        private readonly MockDataRepo _repo = new MockDataRepo();
                
        public IActionResult Index()
        {
            IEnumerable<AlbumModel> albumList= _repo.GetAlbums();
            return View(albumList);
        }

        public IActionResult Details(int id)
        {
            IEnumerable<PhotoModel> photoList = _repo.GetPhotosByAlbumId(id);
            return View(photoList);
        }
    }
    
}