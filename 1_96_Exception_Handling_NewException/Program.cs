using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_96_Exception_Handling_NewException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ProcessOrder();
            }
            catch (MessageQueueException ex)
            {

                throw new OrderProcessingException("Error while processing order", ex);
            }
        }

        private static void ProcessOrder()
        {
            throw new MessageQueueException();
        }
    }
}
