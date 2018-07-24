using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_41_NonAtomic_Operations
{
    class Program
    {
        static int value = 1;
        static void Main(string[] args)
        {
            Task t1 = Task.Run(() => {
                if(value == 1)
                {
                    //Removing the following line will change the output
                    Thread.Sleep(1000);
                    value = 2;
                }

            });

            Task t2 = Task.Run(() => {
                value = 1;
            });

            Task.WaitAll(t1, t2);
            Console.WriteLine(value);

            Console.ReadKey();


            
        }
    }
}
