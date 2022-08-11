using BusinessLayer;
using Models;
using Moq;
using Repositories.UOW;
using Xunit;

namespace OrderTakerTests.Tests
{
    public class BLOrderTests
    {
        private readonly OrdersDbContext _context;

        [Fact]
        public void BLOrder_GetOrderById_ValidId()
        {
            //Arrange
            var mockOrderRepo = new MockOrderRepository().MockGetOrderByIdInvalid();
            var Uow = new UnitOfWork(_context);
            var BLOrder = new BLOrder(Uow);

            //Act
            var myOrder = BLOrder.GetOrderById(1);

            //Assert
            mockOrderRepo.VerifyGetOrderById(Times.Never());
        }
    }
}