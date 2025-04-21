using Assignment6_ErrorHandling.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_ErrorHandling.Services
{
    public class ConnectionService
    {
        private static Random _random = new Random();

        public void ConnectServer()
        {
            if (_random.Next(1, 10) == 1) // 10% chance 
            {
                throw new ServerConnectionException("Failed to connect to server.");
            }
        }
    }
}
