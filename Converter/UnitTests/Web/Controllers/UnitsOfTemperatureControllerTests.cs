using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Services.UnitsOfTemperature;
using Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Web.Controllers;

namespace UnitTests.Web.Controllers
{
    [TestClass]
    public class UnitsOfTemperatureControllerTests
    {
        private readonly Mock<IUnitsOfTemperatureService> unitsOfTemperatureServiceMock = new Mock<IUnitsOfTemperatureService>();
        private UnitsOfTemperatureController controller;

        [TestInitialize]
        public void Init()
        {
            this.controller = new UnitsOfTemperatureController(unitsOfTemperatureServiceMock.Object);
        }

        [TestMethod]
        public void Get_CallsServiceMethod()
        {
            controller.Get();

            unitsOfTemperatureServiceMock.Verify(x => x.GetUnitsOfTemperature(), Times.Once);
        }

        [TestMethod]
        public void Get_ReturnsOkResponse()
        {
            var response = controller.Get();

            Assert.IsInstanceOfType(response, typeof(OkObjectResult));
        }

        [TestMethod]
        public void Get_ReturnsExpectedModel()
        {
            unitsOfTemperatureServiceMock.Setup(x => x.GetUnitsOfTemperature()).Returns(new List<UnitOfTemperatureViewModel>
            {
                new UnitOfTemperatureViewModel(1, "Test")
            }); ;

            var response = controller.Get();

            // Cast response to OkObjectResult to get the content
            var okObjectResult = (OkObjectResult)response;

            Assert.IsInstanceOfType(okObjectResult.Value, typeof(List<UnitOfTemperatureViewModel>));
            Assert.IsInstanceOfType(okObjectResult.Value, typeof(List<UnitOfTemperatureViewModel>));
            Assert.AreEqual(1, ((List<UnitOfTemperatureViewModel>)okObjectResult.Value)[0].Id);
            Assert.AreEqual("Test", ((List<UnitOfTemperatureViewModel>)okObjectResult.Value)[0].Name);
        }

        [TestMethod]
        public void Get_WithId_CallsServiceMethod()
        {
            controller.Get(3);

            unitsOfTemperatureServiceMock.Verify(x => x.GetUnitOfTemperature(3), Times.Once);
        }

        [TestMethod]
        public void Get_WithId_ReturnsOkResponse()
        {
            var response = controller.Get(It.IsAny<int>());

            Assert.IsInstanceOfType(response, typeof(OkObjectResult));
        }

        [TestMethod]
        public void Get_WithId_ReturnsExpectedModel()
        {
            unitsOfTemperatureServiceMock.Setup(x => x.GetUnitOfTemperature(It.IsAny<int>())).Returns(new UnitOfTemperatureViewModel(3, "Test"));

            var response = controller.Get(It.IsAny<int>());

            // Cast response to OkObjectResult to get the content
            var okObjectResult = (OkObjectResult)response;

            Assert.IsInstanceOfType(okObjectResult.Value, typeof(UnitOfTemperatureViewModel));
            Assert.IsInstanceOfType(okObjectResult.Value, typeof(UnitOfTemperatureViewModel));
            Assert.AreEqual(3, ((UnitOfTemperatureViewModel)okObjectResult.Value).Id);
            Assert.AreEqual("Test", ((UnitOfTemperatureViewModel)okObjectResult.Value).Name);
        }

        [TestMethod]
        public void Get_WithId_ReturnsNotFoundWhenInvalidOperationExceptionThrown()
        {
            unitsOfTemperatureServiceMock.Setup(x => x.GetUnitOfTemperature(It.IsAny<int>())).Throws(new InvalidOperationException());

            var response = controller.Get(It.IsAny<int>());

            Assert.IsInstanceOfType(response, typeof(NotFoundResult));
        }
    }
}
