using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6_Passing_Only_Address
{
    class Program
    {
        public static Address ReturnAddressTo(string address)
        {
            Address newAdrress = new Address(address);

            return newAdrress;
        }
        static void Main(string[] args)
        {
            Address theNewAddress = ReturnAddressTo(new Customer().retAddress());

            Console.WriteLine("The Address is {0}", theNewAddress.address);
        }

        public struct Distance
        {
            public int distance;

            public Distance(int distance)
            {
                this.distance = distance;
            }


        }


        public struct Address
        {
            public string address;

            public Address(string address)
            {
                this.address = address;
            }


        }
    }

    public class Customer
    {
        int distance = 300;
        string address = "Hard oded Address";


        public int retDistance()
        {
            return distance;
        }

        public string retAddress()
        {
            return address;
        }
    }
}
