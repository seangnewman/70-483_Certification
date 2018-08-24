using System;
using System.Runtime.Serialization;

namespace _1_96_Exception_Handling_NewException
{
    [Serializable]
    internal class OrderProcessingException : Exception
    {
        public OrderProcessingException()
        {
        }

        public OrderProcessingException(string message) : base(message)
        {
        }

        //public OrderProcessingException(string message, Exception innerException) : base(message, innerException)
        //{
        //}

        public OrderProcessingException(string message, Exception innerException) : base(message, innerException)
        {
            Console.WriteLine("Order Processing Exception");
        }

        protected OrderProcessingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}