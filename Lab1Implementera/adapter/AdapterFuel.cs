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
    public class AdapterFuel : IFuel
        {
            private readonly Fuel _fuel;
            public AdapterFuel(Fuel fuel)
            {
                _fuel = fuel;
            }
            public string GetFuel()
            {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Beep..");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Boop..");
            System.Threading.Thread.Sleep(1000);
            return $"Now that vehicle uses electricity instead because of my adapter design\n";
            }
        }
}
