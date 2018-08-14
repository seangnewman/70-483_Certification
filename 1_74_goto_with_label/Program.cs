using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_74_goto_with_label
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            if (x == 3)
                goto customLabel;
            x++;

            customLabel:
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
