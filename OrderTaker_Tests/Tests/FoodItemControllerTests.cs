using Controllers;
using Moq;
using OrderTaker_Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OrderTaker_Tests.Tests
{
    public class FoodItemControllerTests
    {
        [Fact]
        public void FoodItemController_GetFoodItemPrice_FoodItemExsit()
        {
            //Arrange
            var mockBLFoodItem = new MockBLFoodItem().MockGetFoodItemPrice(5.00m);

            var controller = new FoodItemController(mockBLFoodItem.Object);

            //Act
            var result = controller.GetFoodItemPrice(1);

            //Assert
            Assert.NotNull(result);
            mockBLFoodItem.VerifyGetFoodItemPrice(Times.Once());
        }
    }
}