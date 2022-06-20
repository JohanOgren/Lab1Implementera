using Lab1Implementera.Contract;
using Lab1Implementera.Prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Implementera
{
    public class AdressAdder : ISubject
    {
        private List<IObserver> _observer = new List<IObserver>();

        public void Notify()
        {
            Console.WriteLine("Subject: Notifying all observers....with Observer pattern;D");
            foreach (var o in _observer)
            {
                o.Update(this);
            }
        }

        public void Register(IObserver observer)
        {
            Console.WriteLine("Subhect: Added Observer.");
            _observer.Add(observer);
        }

        public void AdressName()
        {
            Console.WriteLine("Hello, Enter free adress");
            var adres = Console.ReadLine();

            List<Adress> adresses = new List<Adress>();

            adresses.Add(new Adress() { AdressName = adres });
            foreach (var ad in adresses)
            {
                Console.WriteLine($" you wrote {ad.AdressName}");
            }
            Notify();


        }
    }
}
