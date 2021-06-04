using System;
using System.Collections.Generic;
using System.Text;

namespace Services.UnitsOfTemperature
{
    public class UnitsOfTemperatureService : IUnitsOfTemperatureService
    {
        public IEnumerable<(int Id, string Name)> GetUnitsOfTemperature()
        {
            return new List<(int Id, string Name)>
            {
                (1, "Kelvin"),
                (2, "Celcius"),
                (3, "Farenheit")
            };
        }
    }
}
