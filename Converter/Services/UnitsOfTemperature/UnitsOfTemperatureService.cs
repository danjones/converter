using Services.ViewModels;
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
