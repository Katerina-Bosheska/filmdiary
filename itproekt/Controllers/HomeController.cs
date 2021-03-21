using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using itproekt.Models;
using itproekt.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace itproekt.Controllers {

    [Authorize]
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }


        [HttpGet]
        public IActionResult Home() {

            var dbcontext = new DatabaseContext();
            var movieactivity = dbcontext.Activities.OrderByDescending(m => m.ID);
            var profile = dbcontext.Profiles.Find(User.FindFirstValue(ClaimTypes.Name));
            var reviews = dbcontext.Reviews.OrderByDescending(r => r.ID);

            var model = new HomeViewModel { 
                Reviews = reviews.ToList(), MovieActivity = movieactivity.ToList(), Profile = profile 
            };

            return View(model);
        }


        [AllowAnonymous]
        public IActionResult Index() {
            ViewBag.UserUser = User.FindFirstValue(ClaimTypes.Name);
            return View();
        }

        [AllowAnonymous]
        public IActionResult Search(string key) {

            if (key == "")
                return RedirectToAction("Index");

            var dbcontext = new DatabaseContext();
            var movies = dbcontext.Movies;
            var movieresults = new List<Movie>();
            key = key.ToLower();
            foreach (var movie in movies) {
                if (movie.Title.ToLower(). Contains(key) || movie.Director.ToLower().Contains(key) || movie.Cast.ToLower().Contains(key)) {
                    movieresults.Add(movie);
                }
            }

            var users = new List<Profile>();
            foreach(var user in dbcontext.Profiles) {
                if (user.Username.ToLower().Contains(key))
                    users.Add(user);
            }

            var model = new ResultsViewModel { MovieResults = movieresults, UserResults = users, Key = key };
            return View("SearchResult", model);

        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
