using System;

namespace Apress.Data.Services.CustomerService.BusinessLogic
{
    public class CustomerValidationException : Exception
    {
        public CustomerValidationException(string message) : base(message)
        {
        }
    }
}
