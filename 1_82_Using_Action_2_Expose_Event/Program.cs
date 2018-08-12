using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_82_Using_Action_2_Expose_Event
{
    class Program
    {
        public class Pub
        {
            public Action OnChange { get; set; }

            public void Raise()
            {
                if(OnChange != null)
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
