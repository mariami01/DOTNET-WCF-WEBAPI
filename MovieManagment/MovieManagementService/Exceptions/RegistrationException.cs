using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieManagementService.Exceptions
{
    public class RegistrationException : Exception
    {
        public RegistrationException(string message) : base(message)
        {
        }
    }
}