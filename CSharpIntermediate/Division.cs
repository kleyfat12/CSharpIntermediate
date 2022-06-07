using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Division : IOperation
    {
        private double result;
        public void Calculate(double a, double b)
        {
            result = a / b;
        }

        public void Show()
        {
            Console.WriteLine(result);
        }
    }
}
