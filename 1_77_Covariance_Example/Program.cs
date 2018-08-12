using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_77_Covariance_Example
{
    class Program
    {
        public delegate TextWriter CovarianceDel();

        public static StreamWriter MethodStream()
        {
            Console.WriteLine("Method Stream");
            return null;
        }

        public static StreamWriter MethodString()
        {
            Console.WriteLine("Method String");
            return null;
        }


        static void Main(string[] args)
        {
            CovarianceDel del;
            del = MethodStream;
            Console.WriteLine(del());


            del += MethodString;
            Console.WriteLine(del());

            Console.ReadKey();
        }
    }
}
