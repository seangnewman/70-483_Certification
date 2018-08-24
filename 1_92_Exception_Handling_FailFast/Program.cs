using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_92_Exception_Handling_FailFast
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            try
            {
                int i = int.Parse(s);
                if(i == 42)
                {
                    Environment.FailFast("Special Number was Entered");
                }
            }
            finally 
            {

                Console.WriteLine("Program complete."); ;
            }
        }
    }
}
