using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_83_Event_keyword
{
    class Program
    {
        public class Pub
        {
            public event Action OnChange = delegate
            {
                Console.WriteLine("Delegate Called");
            };

            public void Raise()
            {
                if (OnChange != null)
                {
                    OnChange();
                }
            }

        }

        public static void CreateAndRaise()
        {
            Pub p = new Pub();
            p.OnChange += () => Console.WriteLine("Event raised to method 1");
            p.OnChange += () => Console.WriteLine("Event raised to method 2");
            p.Raise();
        }
        static void Main(string[] args)
        {
            CreateAndRaise();

            Console.ReadKey();
        }
    }
}
