using Lab1Implementera.Contract;
using Lab1Implementera.Prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Implementera
{/// <summary>
/// Observer <----------------
/// </summary>
    public class ObserverAdress : ISubject
    {
        public int State { get; set; } = -0;
        private List<IObserver> _observer = new List<IObserver>();

        public void Notify()
        {

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\n Notifying observer....with Observer pattern \n");
            foreach (var o in _observer)
            {
                o.Update(this);
            }
        }

        public void Register(IObserver observer)
        {
            Console.WriteLine($" \nSubject: adding Observer to your object.");
            _observer.Add(observer);
        }

        public void AdressName()
        {
            Console.WriteLine("\nWhat kind of thing would you like to add to that object? Use your imagination.. ");
            var adres = Console.ReadLine();

            List<Adress> adresses = new List<Adress>();

            adresses.Add(new Adress() { AdressName = adres });
            foreach (var ad in adresses)
            {
                Console.WriteLine($"you wrote {ad.AdressName}");
            }
            Notify();


        }
    }
}
