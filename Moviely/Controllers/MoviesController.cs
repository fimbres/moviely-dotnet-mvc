using Microsoft.AspNetCore.Mvc;
using Moviely.Models;

namespace Moviely.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            var movie = new Movie() { Title = "Shrek" };

            return View(movie);
        }
    }
}
