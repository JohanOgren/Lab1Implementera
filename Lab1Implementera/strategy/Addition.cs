using Lab1Implementera.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Implementera.strategy
{ //Strategy
    public class Addition : IMath
    {
        public int Calculate(int val1, int val2)
        {
            return val1 + val2;
        }
    }
}
