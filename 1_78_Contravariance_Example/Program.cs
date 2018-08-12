using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_78_Contravariance_Example
{
    class Program
    {
        public static void DoSomething(TextWriter tw)
        {
            // Because both StreamWriter and StringWriter inherit from TextWriter
            //This becomes a valid result
            Console.WriteLine("Not sure I understand this concept");
        }

        public delegate void ContravarianceDel(StreamWriter tw);

        static void Main(string[] args)
        {
            StreamWriter tw = new StreamWriter("dummy");
            //Because both StreamWriter and StringWriter inherit from TextWriter
            //This becomes a valid result
            ContravarianceDel del = DoSomething;
            del(tw);

            Console.ReadKey();
        }
    }
}
 
