using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_86_Event_Exceptions
{
    class Program
    {
        public class MyArgs : EventArgs
        {
            public MyArgs(int value)
            {
                Value = value;
            }

            public int Value { get; set; }
        }

        public class Pub
        {

            public event EventHandler OnChange = delegate
            {
                Console.WriteLine("Delegate called");
            };
            
            public void Raise()
            {
                OnChange(this, EventArgs.Empty);
            }
        }

        public static void CreateAndRaise()
        {
            Pub p = new Pub();

            p.OnChange += (sender, e) => Console.WriteLine("Subscriber 1 called");
            p.OnChange += (sender, e) => { throw new Exception(); };
            p.OnChange += (sender, e) => Console.WriteLine("Subscriber 1 called");

            p.Raise();
        }

        static void Main(string[] args)
        {
            CreateAndRaise();

            Console.ReadKey();
        }
    }
}
