using System;
using System.Collections.Generic;
using System.Text;

namespace Exceções.Entities.Exceptions
{
    class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message)
        {
        }
    }
}
