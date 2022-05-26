using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IBLOrder
    {
        OrderMaster GetOrderById(int id);

        IEnumerable<OrderMaster> GetAllOrders();

        bool AddOrder(OrderMaster order);

        bool DeleteOrder(int id);
    }
}