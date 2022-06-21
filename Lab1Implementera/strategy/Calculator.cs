using Lab1Implementera.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Implementera.strategy
{ //Strategy
    class Calculator
    {
        private IMath _imath;
        public Calculator(IMath math)
        {
            _imath = math;
        }
        public int Calculate(int val1, int val2)
        {
            return _imath.Calculate(val1, val2);
        }
    }
}
