using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repositories;
using Repositories.UOW;

namespace BusinessLayer
{
    public class BLCustomer : IBLCustomer
    {
        private readonly IUnitOfWork uow;

        public BLCustomer(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return uow.Customer.GetAllCusomers();
        }

        public int AddCustomer(string name)
        {
            if (name == null)
                throw new ArgumentException("Empty name!");
            var id = uow.Customer.AddCustomer(name);
            uow.Complete();

            return id;
        }
    }
}