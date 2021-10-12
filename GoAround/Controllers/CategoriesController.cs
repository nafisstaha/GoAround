using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoAround.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

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
    }
}
