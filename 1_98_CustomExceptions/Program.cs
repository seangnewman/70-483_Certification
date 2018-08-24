using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_98_CustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ProcessOrders();
            }
            catch (OrderProcessingException ex)
            {

                throw;
            }
        }

        private static void ProcessOrders()
        {
            throw new NotImplementedException();
        }
    }
}
