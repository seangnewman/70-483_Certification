using System;

using System.Threading.Tasks;

namespace _1_8_TaskDemo
{
    class Program
    {

        //Demonstrates how to start a task and wait for completion.

        static void Main(string[] args)
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.Write("*");
                }
            });

            t.Wait();

            Console.ReadKey();

            
        }
    }
}
