using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_45_Task_Timout
{
    class Program
    {
        static void Main(string[] args)
        {
            Task longRunning = Task.Run(() => {
                Thread.Sleep(10000);
            });

            int index = Task.WaitAny( new[] { longRunning }, 10000);

            if(index == -1)
            {
                Console.WriteLine("Task timed out");
            }

            Console.ReadKey();

        }
    }
}
