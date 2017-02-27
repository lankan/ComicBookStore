using ComicBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookStore.Data
{
    public class ComicBookRepository
    {

        private static ComicBook[] _comicBooks = new ComicBook[]
        {
           new ComicBook()
            {

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

            },
                   new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 657,
                DescriptionHtml = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
                Artist = new Artist[]
                {
                    new Artist() { name = "Dan Slott", role = "Script" },
                    new Artist() { name = "Marcos Martin", role = "Pencils" },
                    new Artist() { name = "Marcos Martin", role = "Inks" },
                    new Artist() { name = "Muntsa Vicente", role = "Colors" },
                    new Artist() { name = "Joe Caramagna", role = "Letters" }
                },
                Favourite = false
            },
            new ComicBook()
            {
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
                Artist = new Artist[]
                {
                    new Artist() { name = "Jeff Smith", role = "Script" },
                    new Artist() { name = "Jeff Smith", role = "Pencils" },
                    new Artist() { name = "Jeff Smith", role = "Inks" },
                    new Artist() { name = "Jeff Smith", role = "Letters" }
                },
                Favourite = false
            }
    };

        public ComicBook getComicBook(int Id)
        {
            ComicBook comic = null; 
            
            foreach (ComicBook item in _comicBooks)
            {
                if (item.Id == Id)
                {
                    comic = item;
                    break;
                }               
            }
            return comic;
        } 



    }
}