﻿using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var movies = _context.Movies
                .Include(m => m.Genre)
                .ToList();
            return View(movies);
        }

        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new MovieFormVM
            {
                Genres = genres
            };

            return View("MovieForm", viewModel);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies
                .Include(m => m.Genre)
                .SingleOrDefault(x => x.Id == id);
            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormVM
            {
                Movie = movie,
                Genres = _context.Genres.ToList(),
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(MovieFormVM model)
        {
            if (model.Movie.Id == 0)
            {
                /* Without this, caused Exception on SQLError out of range date
                 * becuase AddedDate become 0000-00-00
                */
                model.Movie.AddedDate = DateTime.Now;
                _context.Movies.Add(model.Movie);
            }
            else
            {
                var existingMovie = _context.Movies.Single(m => m.Id == model.Movie.Id);
                existingMovie.Name = model.Movie.Name;
                existingMovie.ReleaseDate = model.Movie.ReleaseDate;
                existingMovie.GenreId = model.Movie.GenreId;
                existingMovie.NumberInStock = model.Movie.NumberInStock;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}