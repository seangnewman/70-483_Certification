using System;
using System.Threading;

namespace _1_4_StoppingThreadDemo
{
    public static class Program
    {
       
        private static void IsThreadRunning(object stopped)
        {
            while (!(bool)stopped)
            {
                Console.WriteLine("Running ...");
                Thread.Sleep(1000);
            }
        }
       
       
        static void Main(string[] args)
        {
            bool stopped = false;
            /*  *****************************************************
             Autor using anonymous functions
             Very JS of him, but most C# legacy code still uses delegates

            This is the way it will be done going forward
              
            Thread t = new Thread(new ThreadStart(() => {
                while (!stopped)
                {
                    Console.WriteLine("Running ...");
                    Thread.Sleep(1000);
                }
            }));
            */

            //Author using anonymous functions before he has explained.
            //Converting to a delegate to focus on concept first 
            //rather than confusing with implementation
            Thread t = new Thread(IsThreadRunning);
            t.Start(stopped);


             
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            stopped = true;   
            t.Join();
        }

       
    }
}
