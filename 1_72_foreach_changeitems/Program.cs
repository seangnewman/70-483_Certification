using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_72_foreach_changeitems
{
    class Program
    {
        private  class Person
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

            foreach(Person person in people)
            {
                person.LastName = "Changed";    // This is perfectly legal
                //person = new Person();          // Cannot reassign within foreach
            }



        }
        static void Main(string[] args)
        {
            CannotChangeForEachVariable();
        }
    }
}
