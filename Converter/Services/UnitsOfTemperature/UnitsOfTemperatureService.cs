using Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.UnitsOfTemperature
{
    public class UnitsOfTemperatureService : IUnitsOfTemperatureService
    {
        private readonly List<UnitOfTemperature> unitsOfTemperature
            = new List<UnitOfTemperature>
            {
                new UnitOfTemperature(1, "Kelvin", x => x, x => x),
                new UnitOfTemperature(2, "Celcius", x => x + 273.15, x => x - 273.15),
                new UnitOfTemperature(3, "Farenheit", x => (x + 459.67) /9 * 5, x => (x * 9 / 5) - 459.67)
            };

        public double Convert(double value, int fromUnitId, int toUnitId)
        {
            var fromUnit = unitsOfTemperature.Single(x => x.Id == fromUnitId);
            var toUnit = unitsOfTemperature.Single(x => x.Id == toUnitId);

            return toUnit.ConvertFromKelvin(fromUnit.ConvertToKelvin(value));
        }

        public IEnumerable<UnitOfTemperatureViewModel> GetUnitsOfTemperature()
        {
            return unitsOfTemperature.Select(x => new UnitOfTemperatureViewModel(x.Id, x.Name)); ;
        }

        public UnitOfTemperatureViewModel GetUnitOfTemperature(int id)
        {
            return unitsOfTemperature
                .Select(x => new UnitOfTemperatureViewModel(x.Id, x.Name))
                .Single(x => x.Id == id);
        }
    }
}
