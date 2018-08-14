using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_57_nested_if_statements
{
    class Program
    {
        static void F()
        {
            Console.WriteLine("function F");
        }
        static void G()
        {
            Console.WriteLine("function G");
        }
        static void Main(string[] args)
        {

            bool x = true;
            bool y = false;
            

            if (x)
            {
                if (y)
                {
                    F();
                }
                else
                {
                    G();
                }
            }

            Console.ReadKey(); 
        }
    }
}
