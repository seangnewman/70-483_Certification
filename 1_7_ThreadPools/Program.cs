using System;
using System.Threading;

namespace _1_7_ThreadPools
{
    class Program
    {
        static void Main(string[] args)
        {
            //ThreadPool are managed by the environment and returned for reuse when task has completed
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from threadpool");
            });

            Console.ReadLine();
           
        }
    }
}
