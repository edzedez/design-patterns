using System;
using System.Runtime.Serialization;

namespace DesignPatterns.SOLID.DependencyInversionPrinciple
{
    [Serializable]
    public class SqlException : Exception
    {
        //Generated to avoid error only
        public SqlException()
        {
        }

        public SqlException(string message) : base(message)
        {
        }

        public SqlException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SqlException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}