using Models;
using Moq;
using Repositories;
using System;
using System.Collections.Generic;

namespace OrderTaker_Tests.Mocks
{
    public class MockOrderRepository : Mock<IOrderRepository>
    {
        public MockOrderRepository MockGetAllOrders(IEnumerable<OrderMaster> result)
        {
            Setup(x => x.GetAllOrders())
                .Returns(result);

            return this;
        }

        public MockOrderRepository VerifyGetAllOrders(Times times)
        {
            Verify(x => x.GetAllOrders(), times);

            return this;
        }

        public MockOrderRepository MockGetOrderById(OrderMaster result)
        {
            Setup(x => x.GetOrderById(It.IsAny<int>()))
                .Returns(result);

            return this;
        }

        public MockOrderRepository MockGetOrderByIdInvalid()
        {
            Setup(x => x.GetOrderById(It.IsAny<int>()))
                .Throws(new Exception());

            return this;
        }

        public MockOrderRepository VerifyGetOrderById(Times times)
        {
            Verify(x => x.GetOrderById(It.IsAny<int>()), times);

            return this;
        }

        public MockOrderRepository MockDeleteOrderById(bool result)
        {
            Setup(x => x.DeleteOrder(It.IsAny<int>()))
                .Returns(result);
            return this;
        }

        public MockOrderRepository MockDeleteOrderByIdInvalid()
        {
            Setup(x => x.DeleteOrder(It.IsAny<int>()))
                .Throws(new Exception());
            return this;
        }

        public MockOrderRepository VerifyDeleteOrderById(Times times)
        {
            Verify(x => x.DeleteOrder(It.IsAny<int>()), times);
            return this;
        }
    }
}