using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(c => c.Genre).ToList();
            return View(movies);
        }

        public ActionResult New()
        {

            var viewModel = new MovieViewModel
            {
                Genre = _context.Genres.ToList()
            };
            return View(viewModel);
        }

        public ActionResult Create(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieViewModel
                {
                    Genre = _context.Genres.ToList(),
                    Movie = movie
                };
                return View("New", viewModel);
            }

            _context.Movies.Add(movie);
            _context.SaveChanges();
            return RedirectToAction("Index","Movie");
        }
    }
}