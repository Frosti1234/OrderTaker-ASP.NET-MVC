using BusinessLayer;
using Models;
using Moq;
using OrderTaker_Tests.Mocks;
using Repositories.UOW;
using System;
using System.Collections.Generic;
using Xunit;

namespace OrderTaker_Tests.Tests
{
    public class BLOrderTests
    {
        [Fact]
        public void BLOrder_GetOrderById_InvalidId()
        {
            //Arrange
            var uow = new UnitOfWork(new MockCustomerRepository().Object, new MockFoodItemRepository().Object, new MockOrderRepository().Object);
            var blOrder = new BLOrder(uow);

            //Act
            Action act = () => blOrder.GetOrderById(-5);

            //Assert
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Invalid order id", exception.Message);
        }

        [Fact]
        public void BLOrder_DeleteOrder_InvalidId()
        {
            //Arrange
            var uow = new UnitOfWork(new MockCustomerRepository().Object, new MockFoodItemRepository().Object, new MockOrderRepository().Object);
            var blOrder = new BLOrder(uow);

            //Act
            Action act = () => blOrder.DeleteOrder(-5);

            //Assert
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Invalid order id", exception.Message);
        }
    }
}