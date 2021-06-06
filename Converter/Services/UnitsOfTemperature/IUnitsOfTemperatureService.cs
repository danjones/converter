using Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.UnitsOfTemperature
{
    public interface IUnitsOfTemperatureService
    {
        /// <summary>
        /// Returns a collection of units of temperature.
        /// </summary>
        /// <returns>Collection of units of temperature</returns>
        IEnumerable<UnitOfTemperatureViewModel> GetUnitsOfTemperature();

        /// <summary>
        /// Returns a single unit of temperature corresponding to the Id provided.
        /// </summary>
        /// <param name="id">Id of the unit of temperature</param>
        /// <returns>Single unit of temperature.</returns>
        /// <exception cref="InvalidOperationException" />
        UnitOfTemperatureViewModel GetUnitOfTemperature(int id);

        /// <summary>
        /// Converts a value from one unit of temperature to another
        /// </summary>
        /// <param name="value">The value to convert</param>
        /// <param name="fromUnitId">Unit to convert from</param>
        /// <param name="toUnitId">Unit to convert to</param>
        /// <returns>The converted value</returns>
        double Convert(double value, int fromUnitId, int toUnitId);
    }
}
