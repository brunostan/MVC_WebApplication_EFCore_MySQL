using System;

namespace MVC_WebApplication.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base(message)
        {
        }
    }
}
