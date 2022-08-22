using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Moviely.Models;
using Moviely.ViewModels;

namespace Moviely.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            var movie = new Movie() { Title = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer
                {
                    Name = "Pedro"
                },
                new Customer
                {
                    Name = "Jeto"
                }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("movies/released/{{year}}/{{month:regex(\\d{{4}}):range(1,12)}}")]
        public IActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}
