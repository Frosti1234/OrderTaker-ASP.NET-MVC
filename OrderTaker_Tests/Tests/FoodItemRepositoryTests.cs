using AutoFixture;
using Microsoft.EntityFrameworkCore;
using Models;
using OrderTaker_Tests.Mocks;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OrderTaker_Tests.Tests
{
    public class FoodItemRepositoryTests
    {
        public static OrdersDbContext GetTestDatabase(string dbName)
        {
            var options = new DbContextOptionsBuilder<OrdersDbContext>()
            .UseInMemoryDatabase(databaseName: dbName)
            .Options;

            var context = new OrdersDbContext(options);

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var testFoodItem = new FoodItem()
            {
                FoodItemId = 1,
                FoodItemName = "test",
                Price = 0,
            };

            context.FoodItems.Add(testFoodItem);
            context.SaveChanges();

            return context;
        }

        [Fact]
        public void FoodItemRepository_GetFoodItemPriceTest()
        {
            //Arrange
            OrdersDbContext testContext = GetTestDatabase("testDataBase");
            var foodItemRepo = new FoodItemRepository(testContext);

            //Act
            var result = foodItemRepo.GetFoodItemPrice(1);

            //Assert
            Assert.Equal(0, result);
        }
    }
}