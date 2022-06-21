using Lab1Implementera.Contract;
using Lab1Implementera.Functionality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Implementera
{//Singelton använder vi här.
    public sealed class Register
    {
        private Register()
        {
        }
        private static Register _register;
        public static Register GetRegister()
        {
            if (_register == null)
            {
                _register = new Register();
            }
            return _register;
        }
        public static void SingeltonRegister()
        {
            Console.WriteLine("Input FirstName");
            var firstName = Console.ReadLine();
            Console.WriteLine("Input LastName");
            var lastName = Console.ReadLine();

            List<Person> people = new();

            people.Add(new Person() { FirstName = firstName, LastName = lastName });

            foreach (Person p in people)
            {
                Console.WriteLine($"FirstName is {p.FirstName} and Lastname is {p.LastName}\n" +
                    $"this is done with Singelton");

            }
        }
    }
}
