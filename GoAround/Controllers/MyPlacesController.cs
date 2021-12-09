using GoAround.Data;
using GoAround.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoAround.Controllers
{
    public class MyPlacesController : Controller
    {
        //db connection
        private readonly ApplicationDbContext _context;

        // constructor DbContext object
        public MyPlacesController(ApplicationDbContext context)
        {
            // public the db connection
            _context = context; 
        }

        public IActionResult Index()
        {
            // Categories list
            var categories = _context.Categories.OrderBy(c => c.Name).ToList();
            return View(categories);
        }

        // GET: MyPlaces/PlacesByCategory
        public IActionResult PlaceByCategory(int id)
        {
            var places = _context.Places
                .Where(p => p.CategoryId == id)
                .OrderBy(p => p.Name)
                .ToList();

            // category name - page heading
            var category = _context.Categories.Find(id);
            ViewBag.Category = category.Name;

            return View(places);
        }

        // POST: /MyPlaces/AddToMyPlaces
        [HttpPost]
        public IActionResult AddToMyPlaces(int PlaceId, int ReviewId)
        {
            // place's rate
            var review = _context.Reviews.Find(ReviewId);
            var rate = review.Rate;

            // the user, user's places
            var userId = GetUserId();

            // save to MyPlaces table in db
            var myPlace = new MyPlace
            {
                PlaceId = PlaceId,
                Rate = rate,
                UserId = userId,
            };

            _context.MyPlaces.Add(myPlace);
            _context.SaveChanges();

            // return to MyPlaceList page
            return RedirectToAction("MyPlacesList");
        }

        private string GetUserId()
        {
            // user has the place in her/his list
            if (HttpContext.Session.GetString("UserId") != null)
            {
                return HttpContext.Session.GetString("UserId");
            }
            else
            {
                // user doesn't have a place list, logged in
                if (User.Identity.IsAuthenticated)
                {
                    HttpContext.Session.SetString("UserId", User.Identity.Name);
                }
                else
                {
                    // user doesn't have a place list, not logged in
                    HttpContext.Session.SetString("UserId", Guid.NewGuid().ToString());
                }
                return HttpContext.Session.GetString("UserId");
            }
        }
    }
}
