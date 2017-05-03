using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.Controllers;
using Shoes.Models;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace ShoesTest.Tests.ControllersTests
{
    public class SalesControllerTest
    {
        [Fact]
        public void Post_MethodAddsItem_Test()
        {
            // Arrange
            SalesController controller = new SalesController();
            Shoes.Models.Sale testSale = new Shoes.Models.Sale();
            testSale.ShoeName = "Gucci Shoe";

            // Act
            controller.Create(testSale);
            ViewResult indexView = new SalesController().Index() as ViewResult;
            var collection = indexView.ViewData.Model as IEnumerable<Shoes.Models.Sale>;

            // Assert
            Assert.Contains<Shoes.Models.Sale>(testSale, collection);
        }
    }
}
