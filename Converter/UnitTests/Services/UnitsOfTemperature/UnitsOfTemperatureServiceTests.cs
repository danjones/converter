using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.UnitsOfTemperature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTests.Services.UnitsOfTemperature
{
    [TestClass]
    public class UnitsOfTemperatureServiceTests
    {
        private UnitsOfTemperatureService service;

        [TestInitialize]
        public void Init()
        {
            service = new UnitsOfTemperatureService();
        }

        [TestMethod]
        public void GetUnitsOfTemperature_Returns3Items()
        {
            var results = service.GetUnitsOfTemperature();

            Assert.AreEqual(3, results.Count());
        }

        [TestMethod]
        public void GetUnitOfTemperature_ReturnsItem()
        {
            var result = service.GetUnitOfTemperature(1);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetUnitOfTemperature_ThrowsExceptionWhenIdDoesNotExist()
        {
            var result = service.GetUnitOfTemperature(99);
        }
    }
}
