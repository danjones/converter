using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ViewModels
{
    public class UnitOfTemperatureViewModel
    {
        public UnitOfTemperatureViewModel() { }
        public UnitOfTemperatureViewModel(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
