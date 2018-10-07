using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_DbContext
{
    class Program
    {
        static void Main(string[] args)
        {
            using ( ShopContext ctx = new ShopContext())
            {
                Address a = new Address
                {
                    AddressLine1 = "Somewhere 1",
                    AddressLine2 = "At some floor",
                    City = "SomeCity",
                    ZipCode = "1111AA"
                };

                Customer c = new Customer()
                {
                    FirstName = "John",
                    LastName = "Doe",
                    BillingAddress = a,
                    ShippingAddress = a
                };

                ctx.Customers.Add(c);
                ctx.SaveChanges();
            }

        }
    }
}
