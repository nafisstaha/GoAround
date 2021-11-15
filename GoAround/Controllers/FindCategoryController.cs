using GoAround.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoAround.Controllers
{
    public class FindCategoryController : Controller
    {
        //db connection
        private readonly ApplicationDbContext _context;

        // constructor DbContext object
        public FindCategoryController(ApplicationDbContext context)
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
    }
}
