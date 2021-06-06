using System;
using System.Collections.Generic;
using System.Text;

namespace Services.UnitsOfTemperature
{
    public class UnitOfTemperature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Func<double, double> ConvertToKelvin { get; set; }
        public Func<double, double> ConvertFromKelvin { get; set; }

        public UnitOfTemperature(int id, string name, Func<double, double> convertToKelvin, Func<double, double> convertFromKelvin)
        {
            this.Id = id;
            this.Name = name;
            this.ConvertFromKelvin = convertFromKelvin;
            this.ConvertToKelvin = convertToKelvin;
        }
    }
}
