using Models;
using Moq;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTaker_Tests.Mocks
{
    public class MockCustomerRepository : Mock<ICustomerRepository>
    {
        public MockCustomerRepository MockGetAllCustomers(IEnumerable<Customer> result)
        {
            Setup(x => x.GetAllCusomers())
                .Returns(result);

            return this;
        }

        public MockCustomerRepository VerifyGetAllCustomers(Times times)
        {
            Verify(x => x.GetAllCusomers(), times);

            return this;
        }
    }
}