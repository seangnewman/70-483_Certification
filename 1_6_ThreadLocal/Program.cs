using System;

using System.Threading;

namespace _1_6_ThreadLocal
{
   

    class Program
    {

        // Return data that is local to the thread

        public static ThreadLocal<int> _field = new ThreadLocal<int>( () =>
        {
            return Thread.CurrentThread.ManagedThreadId;        // Returns info on thread currently executing
        });
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                for(int x=0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thread A : {0}", x);
                }
            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thread B : {0}", x);
                }
            }).Start();

            Console.ReadKey();

        }
    }
}
