using System;
using System.Threading;

namespace _1_3_ParameterizedThreadDemo
{
   public static  class Program
    {
        public static void ThreadMethod(object o)
        {
            // cast the object o to integer
            for(int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);  // Signals that thread has completed
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(5);   // Pass the object (in this case an integer) to thread
            t.Join();       // UI thread waits for other thread(s)
        }
    }
}
