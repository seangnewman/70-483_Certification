using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_Custom_Struct
{
    public struct Point
    {
        public int x, y;

        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Point pt = new Point(4, 9);

            Console.WriteLine("The point is located at {0}, {1}", pt.x, pt.y);
        }
    }
}
