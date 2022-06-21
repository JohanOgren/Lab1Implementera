using Lab1Implementera.adapter;
using Lab1Implementera.Contract;
using Lab1Implementera.strategy;
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
                Console.WriteLine("Press\n1 for Singelton \n2 for Adapter \n3 for Strategy\n4 to exit");
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
                        Console.WriteLine("imagine you have a vehicle that uses fuel\n");
                        Console.WriteLine(thisfuel.GetFuel());
                        Console.WriteLine("Press anything to return to menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        //Strategy
                        Console.Clear();
                        Console.WriteLine("1 for Subtraction\n2 for Addition\n3 for Multiplication");
                        var menyCalc = int.Parse(Console.ReadLine());
                        switch (menyCalc)
                        {
                            case 1:
                                Console.Clear();

                                Console.WriteLine("First input");
                                var subVal = int.Parse(Console.ReadLine());
                                Console.WriteLine("Second input");
                                var subVal2 = int.Parse(Console.ReadLine());
                                Calculator SubCalc = new(new Subtraction());
                                Console.WriteLine($"your total is {SubCalc.Calculate(subVal, subVal2)}");
                                Console.WriteLine("Press anything to return to menu");
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.Clear();

                                Console.WriteLine("First input");
                                var AddVal1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Second input");
                                var AddVal2 = int.Parse(Console.ReadLine());
                                Calculator AddCalc = new(new Addition());
                                Console.WriteLine($"your total is {AddCalc.Calculate(AddVal1, AddVal2)}");
                                Console.WriteLine("Press anything to return to menu");
                                Console.ReadKey();
                                break;

                            case 3:
                                Console.Clear();

                                Console.WriteLine("First input");
                                var mulVal1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Second input");
                                var mulVal2 = int.Parse(Console.ReadLine());
                                Calculator MulCalc = new(new Multiplication());
                                Console.WriteLine($"your total is {MulCalc.Calculate(mulVal1, mulVal2)}");
                                Console.WriteLine("Press anything to return to menu");
                                Console.ReadKey();
                                break;
                            default:
                                break;
                        }
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
