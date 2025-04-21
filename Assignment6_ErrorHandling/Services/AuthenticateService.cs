using Assignment6_ErrorHandling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_ErrorHandling.Services
{
    public class AuthenticationService
    {
        public bool AuthenticatePin(Account account, string pin)
        {
            if (account.IsBlocked) return false;

            if (account.Pin == pin)
            {
                account.InvalidPinAttempts = 0;
                return true;
            }

            account.InvalidPinAttempts++;
            if (account.InvalidPinAttempts >= 3)
            {
                account.IsBlocked = true;
            }
            return false;
        }
    }
}
