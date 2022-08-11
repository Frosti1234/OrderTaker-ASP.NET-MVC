using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repositories
{
    public class FoodItemRepository : IFoodItemRepository
    {
        private readonly OrdersDbContext _context;

        public FoodItemRepository(OrdersDbContext context)
        {
            this._context = context;
        }

        public IEnumerable<FoodItem> GetAllFoodItems()
        {
            return _context.FoodItems;
        }

        public decimal GetFoodItemPrice(int id)
        {
            return _context.FoodItems.SingleOrDefault(x => x.FoodItemId == id).Price;
        }
    }
}