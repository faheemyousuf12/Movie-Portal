using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Vidley.Models;
using Vidley.ViewModel;

namespace Vidley.Controllers
{
	public class MoviesController : Controller
	{
         private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
		//
		// GET: /Movies/
        public ViewResult Index()
        {

            var movies = _context.Movies.ToList();
            return View(movies);

        }
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
        //public ActionResult Index()
        //{
        //    var movie = new Movie() { Name = "The Escape" };
        //    var customers = new List<Customer>
        //    {
        //        new Customer {Name="Customer 1"},
        //        new Customer {Name="Customer 2"}
        //    };
        //    var viewModel = new RandomMovieViewModel
        //    {
        //       Movie = movie,
        //        Customers = customers
        //    };
        //    return View(viewModel);
        //}
            //[Route("movies/released/{year}/{month:regex(\\d{4}:range(1,12)}")]
            //public ActionResult ByReleaseYear(int year, int month)
            //{
            //    return Content(year + "/" + month);
            
            // }
            
		
		
}
	
}