using System;

namespace Shared.Filters.ExceptionFilter
{
    /// <summary>  
    /// This class will allow to generate the custom exception message.  
    /// </summary>  
    public class CustomException : System.Exception
    {
        public CustomException()
        {
        }

        public CustomException(string message) : base(message)
        {
        }

        public CustomException(string message, string responseModel) : base(message)
        {
        }

        public CustomException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}
