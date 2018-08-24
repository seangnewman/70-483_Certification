using System;
using System.Runtime.Serialization;

namespace _1_98_CustomExceptions
{
    [Serializable]
    internal class OrderProcessingException : Exception, ISerializable
    {
        private object entityId;

        public int OrderId { get; set; }
        public OrderProcessingException(int orderId)
        {
            OrderId = orderId;
            this.HelpLink = "http://www.newmanuevers.com";

        }

        public OrderProcessingException()
        {
        }

        public OrderProcessingException(string message) : base(message)
        {
        }

        public OrderProcessingException( int orderId, string message) : base(message)
        {
            OrderId = orderId;
            this.HelpLink = "http://www.newmanuevers.com";
        }

        public OrderProcessingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OrderProcessingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        protected int EntityOperationException(SerializationInfo info, StreamingContext context)
        {
            OrderId = (int)info.GetValue("OrderId", typeof(int));
            return OrderId;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("entityId", entityId, typeof(int));
        }
    }
}