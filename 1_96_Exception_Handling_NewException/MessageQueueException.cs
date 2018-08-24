using System;
using System.Runtime.Serialization;

namespace _1_96_Exception_Handling_NewException
{
    [Serializable]
    internal class MessageQueueException : Exception
    {
        public MessageQueueException()
        {
        }

        public MessageQueueException(string message) : base(message)
        {
        }

        public MessageQueueException(string message, Exception innerException) : base(message, innerException)
        {
            Console.WriteLine("Message Processing Exception");
        }

        protected MessageQueueException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}