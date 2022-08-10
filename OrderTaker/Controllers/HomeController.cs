using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OrderTaker.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IBLFoodItem blFoodItem)
        {
        }

        public IActionResult Index()
        {
            //home method in FoodItemController
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}