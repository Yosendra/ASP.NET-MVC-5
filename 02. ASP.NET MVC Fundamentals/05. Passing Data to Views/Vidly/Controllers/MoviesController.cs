using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            var movie = new Movie
            {
                Name = "Shrek",
            };

            // passing movie through ViewData
            ViewData["Movie"] = movie;

            // passing movie through ViewBag
            //ViewBag.Movie = movie;

            // passing movie through View() method
            //return View(movie);

            return View();
        }
    }
}