using System;
using System.Collections.Generic;
using System.Text;

namespace TorneioDeLuta.Domain.Exceptions
{
    /// <summary>
    /// Exception type for domain exceptions
    /// </summary>
    public class TorneioDeLutaDomainException : Exception
    {
        public TorneioDeLutaDomainException()
        { }

        public TorneioDeLutaDomainException(string message)
            : base(message)
        { }

        public TorneioDeLutaDomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
