using System;
using System.Runtime.Serialization;

namespace ABB_ACCMEX.Datos
{
    [Serializable]
    internal class YourCustomException : Exception
    {
        public YourCustomException()
        {
        }

        public YourCustomException(string message) : base(message)
        {
        }

        public YourCustomException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected YourCustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}