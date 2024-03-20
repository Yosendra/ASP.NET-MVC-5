﻿using System;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetMovies()
        {
            var movies = _context.Movies
                .ToList()
                .Select(Mapper.Map<Movie, MovieDto>);
            return Ok(movies);
        }

        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return NotFound();
            else
            {
                var movieDto = Mapper.Map<MovieDto>(movie);
                return Ok(movieDto);
            }
        }

        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            dto.AddedDate = DateTime.Today;

            var movie = Mapper.Map<Movie>(dto);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            dto.Id = movie.Id;

            var uri = new Uri(Request.RequestUri + "/" + dto.Id);
            return Created(uri, dto);
        }

        [HttpPut]
        public IHttpActionResult UpdateMovie(int id, MovieDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var existingMovie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (existingMovie == null)
            {
                return NotFound();
            }
            else
            {
                dto.AddedDate = existingMovie.AddedDate;

                /* this one trigger The property 'Id' is part of the object's key 
                 * information and cannot be modified.
                 * Need to exclude Id from mapping configuration
                */
                Mapper.Map(dto, existingMovie);
                _context.SaveChanges();

                return Ok();
            }
        }

        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            var existingMovie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (existingMovie == null)
            {
                return NotFound();
            }
            else
            {
                _context.Movies.Remove(existingMovie);
                _context.SaveChanges();

                return Ok();
            }
        }
    }
}
