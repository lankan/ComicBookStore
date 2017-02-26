﻿using System;
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
             ViewBag.SeriesTitle = "The Amazing Spider-Man";

             ViewBag.IssueNo = 700;

             ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";

             ViewBag.Artist = new string[]
            {

                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };

            return View();

        }
    }
}