using System;
using System.Runtime.Serialization;

namespace DataBaseExercise
{
    [Serializable]
    internal class DBError : Exception
    {
        public DBError()
        {
        }

        public DBError(string message) : base(message)
        {
        }

        public DBError(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DBError(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}