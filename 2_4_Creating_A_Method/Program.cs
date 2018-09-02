using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_Creating_A_Method
{
    class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int result = calc.Add(17, 23);
            Console.WriteLine("The result is {0}", result);
        }
    }
}
