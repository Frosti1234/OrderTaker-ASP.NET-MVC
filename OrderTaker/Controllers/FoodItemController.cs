using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class FoodItemController : Controller
    {
        private readonly IBLFoodItem blFoodItem;

        public FoodItemController(IBLFoodItem item)
        {
            this.blFoodItem = item;
        }

        [HttpGet]
        public IActionResult Home()
        {
            return View(blFoodItem.GetFoodItems());
        }

        [HttpGet]
        public JsonResult GetFoodItemPrice(int itemId)
        {
            return Json(blFoodItem.GetFoodItemPrice(itemId));
        }
    }
}