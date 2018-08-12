using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //int n = Convert.ToInt32(Console.ReadLine());

             

            int remainder = 0; int tempAccumulator = 0; int Accumulator = 0;

            while(n > 0)
            {
                remainder = n % 2;
                //n = n / 2;
                n = n >> 1;
                if(remainder == 1)
                {
                    tempAccumulator++;
                    if(tempAccumulator > Accumulator)
                    {
                        Accumulator = tempAccumulator;
                    }
                }
                else
                {
                    tempAccumulator = 0;
                }
            }

            


            Console.WriteLine("Consecutive 1's = {0}", Accumulator);
            Console.ReadKey();
        }
    }
}
