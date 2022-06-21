using Lab1Implementera.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Implementera
{
    public class Observer : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as ObserverAdress).State < 3)
            {
                Console.WriteLine("What every you wrote is now updated in to the Observer Design holder.");
            }
        }
    }
}
