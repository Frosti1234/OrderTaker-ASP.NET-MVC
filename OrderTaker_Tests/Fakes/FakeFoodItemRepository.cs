using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTaker_Tests.Fakes
{
    public class FakeFoodItemRepository : IFoodItemRepository
    {
        private List<FoodItem> _foods = new List<FoodItem>()
      {
         new FoodItem()
        {
            FoodItemId = 1,
            FoodItemName = "test",
            Price = 5.00m,
        }
      };

        public IEnumerable<FoodItem> GetAllFoodItems()
        {
            return _foods;
        }

        public decimal GetFoodItemPrice(int id)
        {
            return _foods.Single(x => x.FoodItemId == id).Price;
        }
    }
}