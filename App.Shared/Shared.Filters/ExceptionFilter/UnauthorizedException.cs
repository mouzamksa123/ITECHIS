using System;

namespace Shared.Filters.ExceptionFilter
{
    /// <summary>  
    /// This class will allow to generate the custom exception message.  
    /// </summary>  
    public class UnauthorizedException : System.Exception
    {
        public UnauthorizedException()
        {
        }

        public UnauthorizedException(string message) : base(message)
        {
        }

        public UnauthorizedException(string message, string responseModel) : base(message)
        {
        }

        public UnauthorizedException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}
