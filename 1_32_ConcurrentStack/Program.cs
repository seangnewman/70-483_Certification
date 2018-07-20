using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1_32_ConcurrentStack
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();
            stack.Push(42);

            int result;
            if(stack.TryPop(out result))
                Console.WriteLine("Popped: {0}", result);

            stack.PushRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            int[] values = new int[10];
            stack.TryPopRange(values);

            foreach(int i in values)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
