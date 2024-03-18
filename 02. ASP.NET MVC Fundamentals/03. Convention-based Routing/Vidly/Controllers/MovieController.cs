using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult Random()
        {
            var movie = new Movie
            {
                Name = "Shrek",
            };

            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            string message = string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy);
            return Content(message);
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}