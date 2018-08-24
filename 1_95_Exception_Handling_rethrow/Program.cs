using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_95_Exception_Handling_rethrow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SomeOperation();
            }
            catch (Exception logEx)
            {

                Log(logEx);
                throw;      //Rethrow the original exception
            }
        }

        private static void SomeOperation()
        {
            throw new NotImplementedException();
        }

        private static void Log(Exception logEx)
        {
            Console.WriteLine("\nThrowing the exception {0}", logEx);
        }
    }
}
