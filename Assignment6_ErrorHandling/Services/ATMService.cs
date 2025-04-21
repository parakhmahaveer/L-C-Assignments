using Assignment6_ErrorHandling.Exceptions;
using Assignment6_ErrorHandling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_ErrorHandling.Services
{
    public class ATMService
    {
        private readonly decimal _atmCashAvailable;

        public ATMService(decimal atmCash)
        {
            _atmCashAvailable = atmCash;
        }

        public void Withdraw(Account account, decimal amount)
        {
            if (amount > account.Balance)
                throw new InsufficientFundsException("Insufficient balance in account.");

            if (amount > _atmCashAvailable)
                throw new InsufficientFundsException("ATM has insufficient cash.");

            if ((account.DailyWithdrawal + amount) > account.DailyLimit)
                throw new DailyLimitExceededException("Daily withdrawal limit exceeded.");

            account.Balance -= amount;
            account.DailyWithdrawal += amount;

            Console.WriteLine($"Withdrawn: ${amount}. Remaining Balance: ${account.Balance}");
        }
    }
}
