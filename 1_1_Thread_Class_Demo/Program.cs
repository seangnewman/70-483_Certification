using System;
using System.Threading;

namespace _1_1_Thread_Class_Demo
{
    public static class Program
    {
        public static void ThreadMethod()
        {
            for (int i=0; i < 10; i++)
            {
                Console.WriteLine("TheadProc: {0}", i);
                Thread.Sleep(0);   // Signals that thread has completed
            }
        }
        public static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread; Do some work.");
                Thread.Sleep(0);  // Signals that thread has completed
            }

            t.Join();   // Signal main thread to wait for completion of other threads

            Console.ReadLine();
        }
    }
}
