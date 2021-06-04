using System;
using System.Collections.Generic;
using System.Text;

namespace Services.UnitsOfTemperature
{
    public interface IUnitsOfTemperatureService
    { 
        IEnumerable<(int Id, string Name)> GetUnitsOfTemperature();
    }
}
