using System;
 
using System.Threading.Tasks;

namespace _1_9_TaskReturnValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;  // The meaning of life
            });

            Console.WriteLine("What is the meaning of Life? {0}!", t.Result);
            Console.ReadKey();
        }
    }
}
