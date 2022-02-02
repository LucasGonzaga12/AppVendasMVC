using System;

namespace SalesWebMVC.Services.Exceptions
{
    public class DbConcurrecyException : ApplicationException
    {
        public DbConcurrecyException(string message) : base(message)
        {

        }
    }
}
