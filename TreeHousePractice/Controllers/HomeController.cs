using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TreeHousePractice.Data;
using TreeHousePractice.Models;

namespace TreeHousePractice.Controllers
{
    public class HomeController : Controller
    {
        private ComicBookRepository _comicBookrepository = null;

        public ActionResult Index()
            {
            var comicbooks = _comicBookrepository.GetComicBooks();

            return View(comicbooks);
            }


        }
}
