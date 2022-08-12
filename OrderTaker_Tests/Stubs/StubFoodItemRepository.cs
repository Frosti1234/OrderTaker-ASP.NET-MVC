using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTaker_Tests.Stubs
{
    public class StubFoodItemRepository : IFoodItemRepository
    {
        public IEnumerable<FoodItem> GetAllFoodItems()
        {
            return new List<FoodItem>()
            {
              new FoodItem()
              {
               FoodItemId = 1,
               FoodItemName = "test",
               Price = 5.00m,
              }
            };
        }

        public decimal GetFoodItemPrice(int id)
        {
            return 5.00m;
        }
    }
}