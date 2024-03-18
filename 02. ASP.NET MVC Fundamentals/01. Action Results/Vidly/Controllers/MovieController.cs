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

            // Return plain text
            //return Content("Hello World!");

            // Return not found
            //return HttpNotFound();

            // Return view page
            //return View(movie);

            // Return void, no helper method from Controller
            //return new EmptyResult();

            /* Redirect to another action method
             * Sometimes we need to pass argument to certain action method
             * We use anonymouse object to pass the argument
            */
            return RedirectToAction("Index", "Home", new { page = 1, sortBy = "Name" });

            // Can be written like this, but above is more common
            //return new ViewResult();
        }
    }
}