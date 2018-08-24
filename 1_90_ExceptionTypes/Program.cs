using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_90_ExceptionTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;

            while (condition)
            {

                string s = Console.ReadLine().Trim(' ');

                
                try
                {
                    int i = int.Parse(s);
                    condition = false;
                }
                catch (ArgumentNullException)
                {

                    Console.WriteLine("You need to enter a value");
                }
                
                catch (FormatException)
                {
                    Console.WriteLine("{0} is not a valid number.  Please try again.", s);
                } 
            }
        }
    }
}
