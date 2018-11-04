using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TreeHousePractice.Data;
using TreeHousePractice.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TreeHousePractice.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookrepository = null;

        public ComicBooksController()
        {
            _comicBookrepository = new ComicBookRepository();
        }
        public ActionResult Index()
        {
            var comicBook = _comicBookrepository.GetComicBooks();

            return View(comicBook);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
        {
                return NotFound();
        }

            var comicBook = _comicBookrepository.GetComicBook((int)id);
       
            return View(comicBook);
        }
    }
}
