using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly OrdersDbContext _context;

        public CustomerRepository(OrdersDbContext context)
        {
            this._context = context;
        }

        public IEnumerable<Customer> GetAllCusomers()
        {
            return _context.Customers;
        }

        public int AddCustomer(string name)
        {
            var customer = new Customer() { CustomerName = name };
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer.CustomerId;
        }
    }
}