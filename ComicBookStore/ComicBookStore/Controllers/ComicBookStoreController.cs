using ComicBookStore.Data;
using ComicBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookStore.Controllers
{
    public class ComicBookStoreController : Controller
    {
        
        private ComicBookRepository _comicBookRepository = null;



        public ComicBookStoreController()
        {
            _comicBookRepository = new ComicBookRepository();
        }
           

        public ActionResult Detail(int? Id)

        {
            if (Id ==null)
            {
                HttpNotFound();
            }
            var returnComic = _comicBookRepository.getComicBook(Id.Value);
            return View(returnComic);

        }

        public ActionResult Index()
        {
            return View(_comicBookRepository.getComicBooks());
        }
 
    }
}