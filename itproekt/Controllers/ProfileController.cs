using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using itproekt.Models;
using itproekt.ViewModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace itproekt.Controllers
{
    public class ProfileController : Controller
    {

        public IActionResult MyProfile() {

            var dbcontext = new DatabaseContext();
            var username = User.FindFirstValue(ClaimTypes.Name);
            var currentuser = dbcontext.Profiles.Find(username);

            return View(currentuser);
        }

        public IActionResult Profile(string id) {

            var dbcontext = new DatabaseContext();
            if (User.FindFirstValue(ClaimTypes.Name) == id) {
                var currentuser = dbcontext.Profiles.Find(id);
                return View("MyProfile", currentuser);
            }
                
            var user = dbcontext.Profiles.Find(id);
            return View("Profile", user);
        }


        public IActionResult Edit() {

            var dbcontext = new DatabaseContext();
            var username = User.FindFirstValue(ClaimTypes.Name);
            var currentuser = dbcontext.Profiles.Find(username);
            var model = new EditProfileViewModel { 
                Username = currentuser.Username, Bio = currentuser.Bio, Picture = currentuser.Picture 
            };

            return View(model);
        }

        public IActionResult ApplyEdit(EditProfileViewModel model) {

            var dbcontext = new DatabaseContext();
            var username = User.FindFirstValue(ClaimTypes.Name);
            var currentuser = dbcontext.Profiles.Find(username);
            currentuser.Bio = model.Bio;
            currentuser.Picture = model.Picture;
            dbcontext.SaveChanges();

            return RedirectToAction("MyProfile");
        }

        public IActionResult Watched() {

            var dbcontext = new DatabaseContext();
            var username = User.FindFirstValue(ClaimTypes.Name);
            var currentuser = dbcontext.Profiles.Find(username);
            ViewBag.Whose = "YOUR MOVIES";

            return View(currentuser);
        }

        public IActionResult Likes() {

            var dbcontext = new DatabaseContext();
            var username = User.FindFirstValue(ClaimTypes.Name);
            var currentuser = dbcontext.Profiles.Find(username);
            ViewBag.Whose = "YOUR LIKES";

            return View(currentuser);
        }

        public IActionResult WatchedBy(string id) {

            var dbcontext = new DatabaseContext();
            var user = dbcontext.Profiles.Find(id);
            ViewBag.Whose = user.Username + "'s movies";

            return View("Watched", user);
        }

        public IActionResult LikesBy(string id) {

            var dbcontext = new DatabaseContext();
            var user = dbcontext.Profiles.Find(id);
            ViewBag.Whose = user.Username + "'s likes";

            return View("Likes", user);
        }

        public IActionResult Watchlist() {

            var dbcontext = new DatabaseContext();
            var username = User.FindFirstValue(ClaimTypes.Name);
            var currentuser = dbcontext.Profiles.Find(username);

            return View(currentuser);
        }

        public IActionResult Reviews() {

            var dbcontext = new DatabaseContext();
            var username = User.FindFirstValue(ClaimTypes.Name);
            var currentuser = dbcontext.Profiles.Find(username);
            ViewBag.Whose = "YOUR REVIEWS";

            return View(currentuser);
        }

        public IActionResult ReviewsBy(int id) {

            var dbcontext = new DatabaseContext();
            var user = dbcontext.Profiles.Find(id);
            ViewBag.Whose = user.Username + "'s movies";

            return View("Reviews", user);
        }

        public IActionResult RemoveFromReviews(int id) {

            var dbcontext = new DatabaseContext();
            var username = User.FindFirstValue(ClaimTypes.Name);
            var currentuser = dbcontext.Profiles.Find(username);
            var allreviews = dbcontext.Reviews;
            var profilereviews = currentuser.Reviews;
            var review = allreviews.Find(id);

            allreviews.Remove(review);
            profilereviews.Remove(review);

            dbcontext.SaveChanges();

            return Content("Review successfully removed");
        }

        public IActionResult RemoveFromList(int id, string list) {

            var dbcontext = new DatabaseContext();
            var username = User.FindFirstValue(ClaimTypes.Name);
            var currentuser = dbcontext.Profiles.Find(username);
            var movie = dbcontext.Movies.Find(id);

            if (list == "liked") {
                var movies = currentuser.Liked;
                movies.Remove(movie);
                currentuser.Liked = movies;
                movie.Likes = movie.Likes - 1;
                dbcontext.SaveChanges();
                return Content("Movie removed from your likes.");
            } else if (list == "watched") {
                var movies = currentuser.Watched;
                movies.Remove(movie);
                currentuser.Watched = movies;
                movie.Watches = movie.Watches - 1;
                dbcontext.SaveChanges();
                return Content("Movie removed from your movies.");
            } else {
                var movies = currentuser.Watchlist;
                movies.Remove(movie);
                currentuser.Watchlist = movies;
                dbcontext.SaveChanges();
                return Content("Movie removed from your watchlist.");
            }

            
        }

        public IActionResult FilterByGenre(string genre, string list) {

            var dbcontext = new DatabaseContext();
            var username = User.FindFirstValue(ClaimTypes.Name);
            var currentuser = dbcontext.Profiles.Find(username);
            var movies = new List<Movie>();
            var viewname = "";

            if (list == "liked") {
                movies = currentuser.Liked;
                viewname = "Likes";
            } 
            else if (list == "watched") {
                movies = currentuser.Watched;
                viewname = "Watched";
            } else {
                movies = currentuser.Watchlist;
                viewname = "Watchlist";
            }
                

            var filtered = new List<Movie>();
            foreach(var movie in movies) {
                if (movie.Genre.Contains(genre))
                    filtered.Add(movie);
            }

            var profile = currentuser;
            profile.Watched = filtered;
            profile.Liked = filtered;
            profile.Watchlist = filtered;

            return View(viewname, profile);
        }

    }
}