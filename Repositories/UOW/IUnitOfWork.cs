using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.UOW
{
    public interface IUnitOfWork
    {
        ICustomerRepository Customer { get; }
        IFoodItemRepository Item { get; }
        IOrderRepository Order { get; }

        Task<int> CompleteAsync();

        int Complete();
    }
}