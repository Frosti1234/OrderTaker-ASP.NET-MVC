using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Repositories
{
    public interface IFoodItemRepository
    {
        IEnumerable<FoodItem> GetAllFoodItems();

        public decimal GetFoodItemPrice(int id);
    }
}