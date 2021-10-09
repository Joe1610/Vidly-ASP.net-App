using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Random()
        {
             var movie = new Movie()
             {
                 Name = "Shrek!"
             };
            var customers = new List<Customer>
             {
                 new Customer {Name = "Customer 1"},
                 new Customer {Name = "Customer 2"}
             };
            var viewModel = new RandomMovieViewModel
            {
                Customers = customers,
            };
             return View(viewModel);
        }
        [Route("movies/released/{year}/{month:regex(\\d{{2}}):range(1, 12)}")]
        public IActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}
