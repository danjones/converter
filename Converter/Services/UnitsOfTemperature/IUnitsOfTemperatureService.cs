﻿using Services.ViewModels;
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
    }
}
