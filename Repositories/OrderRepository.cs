using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrdersDbContext _context;

        public OrderRepository(OrdersDbContext context)
        {
            this._context = context;
        }

        public IEnumerable<OrderMaster> GetAllOrders()
        {
            return _context.OrderMasters.Include(x => x.Customer);
        }

        public OrderMaster GetOrderById(int id)
        {
            return _context.OrderMasters.Include(x => x.Customer).Include(y => y.OrderDetails).ThenInclude(x => x.FoodItem).Where(p => p.OrderMasterId == id).FirstOrDefault();
        }

        public void AddOrder(OrderMaster orderMaster)
        {
            _context.OrderMasters.Add(orderMaster);
        }

        public bool DeleteOrder(int id)
        {
            var removed = false;
            OrderMaster order = GetOrderById(id);

            if (order != null)
            {
                _context.OrderMasters.Remove(order);
                removed = true;
            }

            return removed;
        }
    }
}