using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_73_foreach_compliler_generated
{
    class Program
    {
        private class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }

        private static void CannotChangeForEachVariable()
        {
            var people = new List<Person>
            {
                new Person() {FirstName = "John", LastName = "Doe"},
                new Person() {FirstName = "Jane", LastName = "Doe"}
            };

            //foreach (Person person in people)
            //{
            //    person.LastName = "Changed";    // This is perfectly legal
            //    //person = new Person();          // Cannot reassign within foreach
            //}


            List<Person>.Enumerator e = people.GetEnumerator();

            try
            {
                Person v;
                while (e.MoveNext())
                {
                    v = e.Current;
                    Console.WriteLine("The value for person is {0}, {1}", v.LastName, v.FirstName);
                }
            }
            finally
            {
                System.IDisposable d = e as System.IDisposable;
                if(d != null){
                    d.Dispose();
                }
            }


        }
        static void Main(string[] args)
        {
            CannotChangeForEachVariable();
            Console.ReadKey();
        }
    }
}
