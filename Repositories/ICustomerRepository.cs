using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Repositories
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCusomers();

        public int AddCustomer(string name);
    }
}