using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.UnitsOfTemperature
{
    public class UnitsOfTemperatureService : IUnitsOfTemperatureService
    {
        private readonly List<(int Id, string Name)> unitsOfTemperature
            = new List<(int Id, string Name)>
            {
                (1, "Kelvin"),
                (2, "Celcius"),
                (3, "Farenheit")
            };

        public IEnumerable<(int Id, string Name)> GetUnitsOfTemperature()
        {
            return unitsOfTemperature;
        }

        public (int Id, string Name) GetUnitOfTemperature(int id)
        {
            return unitsOfTemperature.Single(x => x.Id == id);
        }
    }
}
