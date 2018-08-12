using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_87_Manually_Raising_Events
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
                var exceptions = new List<Exception>();

                foreach(Delegate handler in OnChange.GetInvocationList())
                {
                    try
                    {
                        handler.DynamicInvoke(this, EventArgs.Empty);
                    }
                    catch(Exception ex)
                    {
                        exceptions.Add(ex);
                    }
                }

                if (exceptions.Any())
                {
                    throw new AggregateException(exceptions);
                }
                
            }
        }

        public static void CreateAndRaise()
        {
            Pub p = new Pub();

            p.OnChange += (sender, e) => Console.WriteLine("Subscriber 1 called");
            p.OnChange += (sender, e) => {
                throw new Exception();
            };
            p.OnChange += (sender, e) => Console.WriteLine("Subscriber 1 called");

            try
            {
                p.Raise();
            }catch(AggregateException ex)
            {
                Console.WriteLine(ex.InnerExceptions.Count);
            }
           
        }

        static void Main(string[] args)
        {
            CreateAndRaise();

            Console.ReadKey();
        }
    }
}
