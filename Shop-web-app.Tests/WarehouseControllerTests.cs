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
    public class WarehouseControllerTests
    {
        private WarehouseController _warehouseController;
        private IWarehouseService _warehouseService;

        [SetUp]
        public void SetUp()
        {
            //Dependencies
            _warehouseService = A.Fake<IWarehouseService>();

            //system under test
            _warehouseController = new WarehouseController(_warehouseService);
        }

        [Test]
        public void WarehouseController_Details_ReturnsSuccess()
        {
            //Arrange
            var id = 1;
            var product = A.Fake<Product>();
            A.CallTo(() => _warehouseService.Get(id)).Returns(product);
            //Act
            var result = _warehouseController.Details(id);
            //Assert
            Assert.That(result, Is.TypeOf<ViewResult>());
        }
    }
}
