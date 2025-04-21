using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_ErrorHandling.Exceptions
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message) { }
    }

    public class DailyLimitExceededException : Exception
    {
        public DailyLimitExceededException(string message) : base(message) { }
    }

    public class ServerConnectionException : Exception
    {
        public ServerConnectionException(string message) : base(message) { }
    }
}
