using Shop_web_app.Services.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeItEasy;
using Shop_web_app.Models;
using Shop_web_app.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Shop_web_app.Tests
{
    [TestFixture]
    public class ProductControllerTests
    {
        private ProductController _productController;
        private IWarehouseService _warehouseService;

        [SetUp]
        public void SetUp()
        {
            //Dependencies
            _warehouseService = A.Fake<IWarehouseService>();

            //system under test
            _productController = new ProductController(_warehouseService);
        }

        [Test]
        public void ProductController_Product_ReturnsSuccess()
        {
            //Arrange
            var product = A.Fake<Product>();
            A.CallTo(() => _warehouseService.Get(product.Id)).Returns(product);
            //Act
            var result = _productController.Product;
            //Assert
            Assert.That(result, Is.TypeOf<Func<IActionResult>>());
        }

        [Test]
        public void ProductController_List_ReturnsSuccess()
        {
            //Arrange
            var productList = A.Fake<List<Product>>();
            A.CallTo(() => _warehouseService.GetAll()).Returns(productList);
            //Act
            var result = _productController.List;
            //Assert
            Assert.That(result, Is.TypeOf<Func<IActionResult>>());
        }
    }
}
