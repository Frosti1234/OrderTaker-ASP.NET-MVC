using Models;
using Repositories.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BLFoodItem : IBLFoodItem
    {
        private readonly IUnitOfWork uow;

        public BLFoodItem(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public IEnumerable<FoodItem> GetFoodItems()
        {
            return uow.Item.GetAllFoodItems();
        }

        public decimal GetFoodItemPrice(int id)
        {
            if (id < default(int))
                throw new ArgumentException("Invalid item price id");
            return uow.Item.GetFoodItemPrice(id);
        }
    }
}