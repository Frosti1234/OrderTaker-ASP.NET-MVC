using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace BusinessLayer
{
    public interface IBLFoodItem
    {
        IEnumerable<FoodItem> GetFoodItems();

        public decimal GetFoodItemPrice(int id);
    }
}