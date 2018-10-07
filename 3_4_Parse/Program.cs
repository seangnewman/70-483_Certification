using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4_Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "true";
            bool b = bool.Parse(value);
            Console.WriteLine(b);
        }
    }
}
