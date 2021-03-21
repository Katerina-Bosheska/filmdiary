using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using itproekt.Models;
using itproekt.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace itproekt.Controllers
{
    public class MovieController : Controller
    {
       

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public IActionResult CreateMovie(Movie model) {

            if (!ModelState.IsValid) {

                return View(model);
            }

            var dbcontext = new DatabaseContext();
            dbcontext.Movies.Add(model);
            dbcontext.SaveChanges();

            return RedirectToAction("AddMovie", "Account");
        }

        public IActionResult MovieDetails(int id) {

            var dbcontext = new DatabaseContext();
            var movie = dbcontext.Movies.Find(id);
            var allreviews = dbcontext.Reviews;

            if (movie == null)
                return RedirectToAction("Index", "Home");

            var reviews = new List<Review>();
            foreach(var review in allreviews) {
                if (review.Movie.ID == movie.ID)
                    reviews.Add(review);
            }

            var model = new MovieDetailsViewModel { Movie = movie, Reviews = reviews };

            return View("MovieDetails", model);
        }

        public IActionResult AddToWatchlist(int id) {

            var dbcontext = new DatabaseContext();
            var movie = dbcontext.Movies.Find(id);

            var currentUsername = User.FindFirstValue(ClaimTypes.Name);
            var currentUser = dbcontext.Profiles.Find(User.FindFirstValue(ClaimTypes.Name));

            var watchlist = currentUser.Watchlist;

            if (watchlist.Contains(movie)) {
                return Content("This movie is already on your Watchlist.");
            }

            watchlist.Add(movie);
            currentUser.Watchlist = watchlist;
            dbcontext.SaveChanges();

            return Content("Movie added to your Watchlist.");
        }

        public IActionResult AddToLiked(int id) {

            var dbcontext = new DatabaseContext();
            var movie = dbcontext.Movies.Find(id);

            var currentUser = dbcontext.Profiles.Find(User.FindFirstValue(ClaimTypes.Name));

            var liked = currentUser.Liked;

            if (liked.Contains(movie))
                return Content("You've already liked this movie.");

            liked.Add(movie);
            currentUser.Liked = liked;

            var movieactivities = dbcontext.Activities;
            movieactivities.Add(new MovieActivity { Action = "liked", Profile = currentUser, Movie = movie });

            movie.Likes = movie.Likes + 1;

            dbcontext.SaveChanges();

            return Content("Movie Liked");
        }

        public IActionResult AddToWatched(int id) {

            var dbcontext = new DatabaseContext();
            var movie = dbcontext.Movies.Find(id);

            var currentUser = dbcontext.Profiles.Find(User.FindFirstValue(ClaimTypes.Name));

            var watched = currentUser.Watched;
            var watchlist = currentUser.Watchlist;

            if (watched.Contains(movie))
                return Content("You've already watched this movie.");

            if (watchlist.Contains(movie)){
                watchlist.Remove(movie);
                currentUser.Watchlist = watchlist;
            }

            watched.Add(movie);
            currentUser.Watched = watched;

            var movieactivities = dbcontext.Activities;
            movieactivities.Add(new MovieActivity { Action = "watched", Profile = currentUser, Movie = movie });

            movie.Watches = movie.Watches + 1;

            dbcontext.SaveChanges();

            return Content("Movie marked as watched.");
        }

        public IActionResult WriteReview(int id) {

            var dbcontext = new DatabaseContext();
            var movie = dbcontext.Movies.Find(id);

            ReviewViewModel model = new ReviewViewModel {
                Movie = movie
            };

            return View(model);
        }

        public IActionResult PostReview(ReviewViewModel model, int id) {

            var dbcontext = new DatabaseContext();
            var movie = dbcontext.Movies.Find(id);

            if (!ModelState.IsValid) {
                model.Movie = movie;
                return View("WriteReview", model);
            }

            
            var currentUser = dbcontext.Profiles.Find(User.FindFirstValue(ClaimTypes.Name));

            var review = new Review {
                Movie = movie, Likes = 0, Rating = model.Rating.ToString(), ReviewText = model.ReviewText,
                Writer = currentUser
            };

            currentUser.Reviews.Add(review);
            dbcontext.Reviews.Add(review);
            dbcontext.SaveChanges();

            if(movie != null)
                return RedirectToAction("MovieDetails", new { id = movie.ID });
            else
                return RedirectToAction("MovieDetails", new { id = 1 });
        }

        public IActionResult LikeReview(int reviewid) {

            var dbcontext = new DatabaseContext();
            var review = dbcontext.Reviews.Find(reviewid);
            review.Likes = review.Likes + 1;
            dbcontext.SaveChanges();
            
            return Content("Successful");
        }

        public IActionResult FilterByGenre(string genre) {

            var dbcontext = new DatabaseContext();
            var movies = dbcontext.Movies.OrderByDescending(m => m.ID);

            var filtered = new List<Movie>();
            if (genre == "All")
                return View("Explore", movies);
            foreach (var movie in movies) {
                if (movie.Genre.Contains(genre))
                    filtered.Add(movie);
            }

            return View("Explore", filtered);
        }

        public IActionResult Explore() {

            var dbcontext = new DatabaseContext();
            var movies = dbcontext.Movies.OrderByDescending(m => m.ID);
            return View(movies);
        }

    }
}