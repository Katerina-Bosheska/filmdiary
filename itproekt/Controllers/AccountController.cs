using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using itproekt.ViewModels;
using itproekt.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace itproekt.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
                RoleManager<IdentityRole> roleManager) {

            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register() {

            /* get current user
            var username = User.FindFirstValue(ClaimTypes.Name);
            ViewBag.CurrentUser = username;
            */
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model) {

            if (!ModelState.IsValid) {

                return View(model);
            }

            var user = new ApplicationUser { Email = model.Email, UserName = model.Username };
            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded) {

                //await userManager.AddToRoleAsync(user, "user");

                var profile = new Profile {
                    Username = model.Username, Picture = "/images/default-profile.jpg",
                    Bio = "", FavoriteMovies = new List<String>(), Liked = new List<Movie>(), Reviews = new List<Review>(),
                    Watched = new List<Movie>(), Watchlist = new List<Movie>()
                };

                var dbcontext = new DatabaseContext();
                dbcontext.Profiles.Add(profile);
                dbcontext.SaveChanges();

                await signInManager.PasswordSignInAsync(model.Username, model.Password, false, false);
                return RedirectToAction("Home");
            }

            foreach(var error in result.Errors) {

                ModelState.AddModelError("", error.Description);
            }

            return View(model);
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<IActionResult> CreateRole() {

            ApplicationUser user = await userManager.FindByNameAsync(User.FindFirstValue(ClaimTypes.Name));
            bool isinrole = await userManager.IsInRoleAsync(user, "Administrator");
            if (isinrole == false)
                return RedirectToAction("Login");

            return View();
        }


        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model) {

            if (!ModelState.IsValid) {

                return View(model);
            }

            IdentityRole identityRole = new IdentityRole { Name = model.RoleName };

            IdentityResult result = await roleManager.CreateAsync(identityRole);

            if (result.Succeeded) {

                return RedirectToAction("Home", "Account");
            }

            foreach(IdentityError error in result.Errors) {

                ModelState.AddModelError("", error.Description);
            }

            return View(model);
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login() {

            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model) {

            if (!ModelState.IsValid) {

                return View(model);
            }

            var result = await signInManager.PasswordSignInAsync(model.Username, model.Password, false, false);

            if (result.Succeeded) {

                return RedirectToAction("Home", "Account");
            } 

            ModelState.AddModelError("", "Invalid Login Attempt");

            return View(model);
        }

        public async Task<IActionResult> Home() {

            var dbcontext = new DatabaseContext();
            var movieactivity = dbcontext.Activities.OrderByDescending(m => m.ID);
            var profile = dbcontext.Profiles.Find(User.FindFirstValue(ClaimTypes.Name));
            var reviews = dbcontext.Reviews.OrderByDescending(r => r.ID);

            var model = new HomeViewModel {
                Reviews = reviews.ToList(), MovieActivity = movieactivity.ToList(), Profile = profile
            };

            var rolename = "";
            ApplicationUser user = await userManager.FindByNameAsync(User.FindFirstValue(ClaimTypes.Name));
            bool roleOfUser = await userManager.IsInRoleAsync(user, "Administrator");
            if (roleOfUser == true)
                rolename = "Administrator";
            else rolename = "Guest";

            ViewBag.Role = rolename;

            return View("../Home/Home", model);
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<IActionResult> AddRoleToUser() {

            ApplicationUser user = await userManager.FindByNameAsync(User.FindFirstValue(ClaimTypes.Name));
            bool isinrole = await userManager.IsInRoleAsync(user, "Administrator");
            if (isinrole == false)
                return RedirectToAction("Login");

            return View();
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> AddRoleToUser(RoleToUserViewModel model) {

            if (!ModelState.IsValid) {

                return View(model);
            }

            string rolename = model.RoleName;
            string username = model.Username;

            bool roleExists = await roleManager.RoleExistsAsync(rolename);
            ApplicationUser user = await userManager.FindByNameAsync(username);

            if (roleExists && user != null) {

                if(model.RemoveRoles == true) {
                    var rolesOfUser = await userManager.GetRolesAsync(user);
                    if(rolesOfUser != null) {
                        await userManager.RemoveFromRolesAsync(user, rolesOfUser);
                    }
                }

                var result = await userManager.AddToRoleAsync(user, rolename);

                if (result.Succeeded) {

                    return RedirectToAction("Home", "Account");
                }

                foreach(var error in result.Errors) {

                    ModelState.AddModelError("", error.Description);
                }
            } else {

                ModelState.AddModelError("", "The rolename or the user doesn't exist in the databse.");
            }

            return View(model);
        }

        public async Task<IActionResult> Logout() {

            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> AddMovie() {

            ApplicationUser user = await userManager.FindByNameAsync(User.FindFirstValue(ClaimTypes.Name));
            bool isinrole = await userManager.IsInRoleAsync(user, "Administrator");
            if (isinrole == false)
                return RedirectToAction("Login");

            return View("../Movie/CreateMovie");
        }


    }
}