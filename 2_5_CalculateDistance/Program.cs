using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_CalculateDistance
{
    class Program
    {
        public static Distance CalculateDistanceTo(Customer customer)
        {
            Distance newDistance = new Distance(customer.retDistance());

            return newDistance;
            

          
        }
        static void Main(string[] args)
        {
            Console.WriteLine("The distance is {0}", CalculateDistanceTo(new Customer()).distance);
        }

        public struct Distance 
        {   
          public int distance;

          public Distance(int distance)
          {
            this.distance = distance;
          }
         
        
        }
}

    public class Customer
    {
        int distance = 300;
        

        public int retDistance()
        {
            return distance;
        }
    }
}
