using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shoes.Models;
using Xunit;


namespace SaleTest.Tests
{
    public class ShoeTest
    {
        [Fact]
        public void GetDescriptionTest()
        {
            //Arrange
            var sale = new Sale();
            sale.ShoeName = "Gucci Shoe";

            //Act
            var result = sale.ShoeName;

            //Assert
            Assert.Equal("Gucci Shoe", result);
        }
    }
}
