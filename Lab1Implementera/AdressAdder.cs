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
    public class AdressAdder : ISubject
    {
        public int state { get; set; } = -0;
        private List<IObserver> _observer = new List<IObserver>();

        public void Notify()
        {

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\n Notifying all observers....with Observer pattern;D \n");
            foreach (var o in _observer)
            {
                o.Update(this);
            }
        }

        public void Register(IObserver observer)
        {
            Console.WriteLine($" \n Subject: Added Observer.");
            _observer.Add(observer);
        }

        public void AdressName()
        {
            Console.WriteLine("\n Hello, Enter anything");
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
    class Observer : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as AdressAdder).state < 3)
            {
                Console.WriteLine("What every you wrote is now updated because of Observer Design");
            }
        }
    }
}
