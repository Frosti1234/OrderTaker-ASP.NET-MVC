using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repositories
{
    public interface IOrderRepository
    {
        IEnumerable<OrderMaster> GetAllOrders();

        OrderMaster GetOrderById(int id);

        void AddOrder(OrderMaster orderMaster);

        bool DeleteOrder(int id);
    }
}