using Lab1Implementera.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Implementera.adapter
{/// <summary>
/// Adapter använder vi här.
/// </summary>
    public class Fuel 
    {
        public string GetFuelRequest()
        {
            return "This Vehicle Uses GasFuel";
        }
    }
    public class Fuels : IFuel
    {
        private readonly Fuel _fuel;
        public Fuels( Fuel fuel)
        {
            _fuel = fuel;
        }
        public string GetFuel()
        {
            return $"This is a adapter for my fuel request";
        }
    }
}
