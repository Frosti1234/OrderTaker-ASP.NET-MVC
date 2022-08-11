using Models;
using System;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;

namespace OrderTaker_Tests.Mocks
{
    public class MockFoodItemRepository : Mock<IFoodItemRepository>
    {
        public MockFoodItemRepository MockGetAllOrders(IEnumerable<FoodItem> result)
        {
            Setup(x => x.GetAllFoodItems())
                .Returns(result);

            return this;
        }

        public MockFoodItemRepository VerifyGetAllOrders(Times times)
        {
            Verify(x => x.GetAllFoodItems(), times);

            return this;
        }

        public MockFoodItemRepository MockGetFoodItemPrice(decimal result)
        {
            Setup(x => x.GetFoodItemPrice(It.IsAny<int>()))
                .Returns(result);

            return this;
        }

        public MockFoodItemRepository MockGetFoodItemPriceInvalid()
        {
            Setup(x => x.GetFoodItemPrice(It.IsAny<int>()))
                .Throws(new Exception());

            return this;
        }

        public MockFoodItemRepository VerifyGetFoodItemPrice(Times times)
        {
            Verify(x => x.GetFoodItemPrice(It.IsAny<int>()), times);

            return this;
        }
    }
}