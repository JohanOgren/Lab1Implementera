using Lab1Implementera.adapter;
using Lab1Implementera.Contract;
using Lab1Implementera.Functionality;
using System;
using System.Collections.Generic;

namespace Lab1Implementera
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singelton
            Register r = Register.GetRegister();
            r.singeltonRegister();

            //Adapter
            Fuel fuels = new Fuel();
            IFuel thisfuel = new Fuels(fuels);
            Console.WriteLine(fuels.GetFuelRequest());

            Console.WriteLine(thisfuel.GetFuel());

            //Observer
            var subject = new AdressAdder();
            var observer = new Observer();
            subject.Register(observer);
            subject.AdressName();


            Console.WriteLine("The End..");
            Console.ReadKey();
        }
    }
}
