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
        public ActionResult Detail()

        {
            var comicbook = new ComicBook()
            {
                private ComicBookRepository comicBookRepo = new ComicBookRepository();
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artist = new Artist[]
                {
                   new Artist{role ="Script" , name="Dan Slott"},
                   new Artist{role ="Pencils" , name="Humberto Ramos"},
                   new Artist{role ="Inks" , name="Victor Olazaba"},
                   new Artist{role ="Colors" , name="Edgar Delgado"},
                   new Artist{role ="Letters" , name="Chris Eliopoulos"},
                }

            };
            
            return View(comicbook);

        }
    }
}