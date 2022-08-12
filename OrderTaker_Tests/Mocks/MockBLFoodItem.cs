using BusinessLayer;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTaker_Tests.Mocks
{
    public class MockBLFoodItem : Mock<IBLFoodItem>
    {
        public MockBLFoodItem MockGetFoodItemPrice(decimal result)
        {
            Setup(x => x.GetFoodItemPrice(It.IsAny<int>()))
                .Returns(result);

            return this;
        }

        public MockBLFoodItem MockGetFoodItemPriceInvalid()
        {
            Setup(x => x.GetFoodItemPrice(It.IsAny<int>()))
                .Throws(new Exception());

            return this;
        }

        public MockBLFoodItem VerifyGetFoodItemPrice(Times times)
        {
            Verify(x => x.GetFoodItemPrice(It.IsAny<int>()), times);

            return this;
        }
    }
}