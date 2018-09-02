using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7_Named_Optional_Arguments
{
    class Program
    {
        public static void MyMethod(int firstArgument, string secondArgument = "default value", bool thirdArgument = false)
        {
            Console.WriteLine("First argument {0}, second argument {1}, third argument {2}", firstArgument, secondArgument, thirdArgument);
        }

        public static void CallingMethod()
        {
            MyMethod(1, thirdArgument: true);
        }
        static void Main(string[] args)
        {
            CallingMethod();
        }
    }
}
