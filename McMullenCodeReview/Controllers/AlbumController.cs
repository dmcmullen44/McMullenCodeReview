using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using McMullenCodeReview.Data;
using Microsoft.AspNetCore.Mvc;

namespace McMullenCodeReview.Controllers
{
    public class AlbumController : Controller
    {
        private readonly IDataRepo _data;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int Id)
        {
            return View();
        }
    }
    
}