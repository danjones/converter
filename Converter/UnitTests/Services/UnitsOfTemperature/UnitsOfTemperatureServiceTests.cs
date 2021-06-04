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
    }
}
