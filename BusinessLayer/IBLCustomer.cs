using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace BusinessLayer
{
    public interface IBLCustomer
    {
        IEnumerable<Customer> GetCustomers();

        public int AddCustomer(string name);
    }
}