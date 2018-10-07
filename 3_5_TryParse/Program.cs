using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_TryParse
{
    class Program
    {
        static void Main(string[] args)
        {

            string value = "one";
            int result;

            bool success = int.TryParse(value, out result);

            if (success)
            {
                Console.WriteLine($"The value is {value}");
            }
            else
            {
                Console.WriteLine($"{value} is not a valid value");
            }
        }
    }
}
