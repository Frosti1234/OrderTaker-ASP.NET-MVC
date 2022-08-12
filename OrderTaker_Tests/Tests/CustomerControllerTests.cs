using BusinessLayer;
using Controllers;
using Models;
using Moq;
using OrderTaker_Tests.Mocks;
using Repositories.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OrderTaker_Tests.Tests
{
    public class CustomerControllerTests
    {
        [Fact]
        public void CustomerController_GetCustomers_CustomersExsist()
        {
            //Arrange
            var mockCustomers = new List<Customer>()
            {
                new Customer()
                {
                    CustomerId = 1,
                    CustomerName ="Test"
                }
            };

            var mockCustomerRepo = new MockCustomerRepository().MockGetAllCustomers(mockCustomers);
            var uow = new UnitOfWork(mockCustomerRepo.Object, new MockFoodItemRepository().Object, new MockOrderRepository().Object);
            var blCustomer = new BLCustomer(uow);
            var controller = new CustomerController(blCustomer);

            //Act
            var result = controller.GetCustomers();

            //Assert
            Assert.NotNull(result);
            mockCustomerRepo.VerifyGetAllCustomers(Times.Once());
        }
    }
}