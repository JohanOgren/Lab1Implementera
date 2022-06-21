using Lab1Implementera.adapter;
using Lab1Implementera.Contract;
using System;

namespace Lab1Implementera
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var starter = true;
            while (starter == true)
            {
                Console.WriteLine("Press\n1 for Singelton \n2 for Adapter \n3 for Observer\n4 to exit");
                var meny = int.Parse(Console.ReadLine());
                switch (meny)
                {
                    
                    case 1:
                        //Singelton
                        Register r = Register.GetRegister();
                        Register.SingeltonRegister();
                        Console.WriteLine("Press anything to return to menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        //Adapter
                        Fuel fuels = new();
                        IFuel thisfuel = new AdapterFuel(fuels);
                        Console.WriteLine(Fuel.GetFuelRequest());

                        Console.WriteLine(thisfuel.GetFuel());
                        Console.WriteLine("Press anything to return to menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        //Observer
                        var subject = new ObserverAdress();
                        var observer = new Observer();
                        subject.Register(observer);
                        subject.AdressName();
                        Console.WriteLine("Press anything to return to menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                    default:
                    case 4:
                        
                        starter = false;
                        break;
                }
            }
        }
    }
}
