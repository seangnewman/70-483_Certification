using System;

using System.Threading.Tasks;

namespace _1_10_TaskContinuation
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;  // The meaning of life
            }).ContinueWith((result)=>
            {
                return result.Result * 2;
            });

            Console.WriteLine("What is the meaning of Life doubled? {0}!", t.Result);
            Console.ReadKey();
        }
    }
}
