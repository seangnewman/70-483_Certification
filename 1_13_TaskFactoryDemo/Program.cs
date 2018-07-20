using System;
using System.Threading;
using System.Threading.Tasks;

namespace _1_13_TaskFactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Task[] tasks = new Task[3];

            // All three tasks run simultaneous
            tasks[0] = Task.Run(()=>
            {
                Thread.Sleep(1000);
                Console.WriteLine(1);
                return 1;

             });
            tasks[1] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine(1);
                return 2;

            });
            tasks[2] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine(1);
                return 3;

            });

            Task.WaitAll(tasks);  // All tasks have to complete

        }
    }
}
