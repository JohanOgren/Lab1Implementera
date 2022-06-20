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
            Register r = Register.GetRegister();
            r.singeltonRegister();


            Fuel fuels = new Fuel();
            IFuel thisfuel = new Fuels(fuels);

            Console.WriteLine(thisfuel.GetFuel());

            Console.WriteLine("The End..");
            Console.ReadKey();
        }
    }
}
