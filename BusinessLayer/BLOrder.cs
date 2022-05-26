using Models;
using Repositories.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BLOrder : IBLOrder
    {
        private readonly IUnitOfWork uow;

        public BLOrder(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public OrderMaster GetOrderById(int id)
        {
            if (id <= default(int))
                throw new ArgumentException("Invalid order id");

            return uow.Order.GetOrderById(id);
        }

        public IEnumerable<OrderMaster> GetAllOrders()
        {
            return uow.Order.GetAllOrders();
        }

        public bool AddOrder(OrderMaster order)
        {
            if (order == null)
                throw new InvalidOperationException("Empty order");

            uow.Order.AddOrder(order);
            uow.Complete();

            return true;
        }

        public bool DeleteOrder(int id)
        {
            if (id <= default(int))
                throw new ArgumentException("Invalid order id");

            var isremoved = uow.Order.DeleteOrder(id);
            if (isremoved)
                uow.Complete();

            return isremoved;
        }
    }
}