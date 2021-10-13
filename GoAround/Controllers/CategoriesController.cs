using GoAround.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoAround.Controllers
{
    public class CategoriesController : Controller
    {
        //index category
        public IActionResult Index()
        {
            //generating a list
            var categories = new List<Category>();

            //category's loop
            for (var i = 1; i < 6; i++)
            {
                categories.Add(new Category { CategoryId = i, Name = "Category " + i.ToString() });
            }

            //view categories
            return View(categories);
        }

        //browse category
        //a method for displaying the list when the user click a category
        public IActionResult Browse(string category)
        {
            //checking an empty or missed category and take back the user to category list
            if (category == null)
            {
                return RedirectToAction("Index");
            }

            //store the input parameter for displaying
            ViewBag.category = category;

            return View();
        }

        //create category
        public IActionResult Create()
        {
            return View();
        }
    }
}
