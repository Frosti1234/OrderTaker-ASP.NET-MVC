using BusinessLayer;
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
    public class UowTests
    {
        [Fact]
        public void Uow_Create_ReposNotNull()
        {
            //Arrange
            var uow = new UnitOfWork(new MockCustomerRepository().Object, new MockFoodItemRepository().Object, new MockOrderRepository().Object);

            //Act
            var uowOrder = uow.Order;
            var uowCustomer = uow.Customer;
            var uowItem = uow.Item;

            //Assert
            Assert.NotNull(uowOrder);
            Assert.NotNull(uowCustomer);
            Assert.NotNull(uowItem);
        }
    }
}