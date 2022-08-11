using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repositories.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OrdersDbContext _context;
        private ICustomerRepository _customer;
        private IFoodItemRepository _foodItem;
        private IOrderRepository _order;

        public UnitOfWork(OrdersDbContext context)
        {
            this._context = context;
        }

        public UnitOfWork(ICustomerRepository Crepo, IFoodItemRepository Irepo, IOrderRepository Orepo)
        {
            this._customer = Crepo;
            this._foodItem = Irepo;
            this._order = Orepo;
        }

        public ICustomerRepository Customer
        {
            get
            {
                if (this._customer == null)
                {
                    this._customer = new CustomerRepository(_context);
                }
                return this._customer;
            }
        }

        public IFoodItemRepository Item
        {
            get
            {
                if (this._foodItem == null)
                {
                    this._foodItem = new FoodItemRepository(_context);
                }
                return this._foodItem;
            }
        }

        public IOrderRepository Order
        {
            get
            {
                if (this._order == null)
                {
                    this._order = new OrderRepository(_context);
                }
                return this._order;
            }
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose() => _context.Dispose();
    }
}