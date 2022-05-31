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
        private readonly IDataRepo _repo;

        //Dependency Injection 
        public AlbumsController(IDataRepo repo)
        {
            _repo = repo;
        }
        //private readonly IDataRepo _data;        
                
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