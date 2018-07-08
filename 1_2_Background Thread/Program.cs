using System;
using System.Threading;

namespace _1_2_Background_Thread
{

    
    public static class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProd : {0}", i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            // If set to false, the  UI thread waits for completion of background task
            //If set to true, the UI thread completes and ends program
            t.IsBackground = true;    
            t.Start();

            //Console.ReadLine();
        }
    }
}
