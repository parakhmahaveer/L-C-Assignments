using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodleAssignment5.Model
{
    public class Wallet
    {
        private decimal _balance;

        public Wallet(decimal initialBalance = 0)
        {
            _balance = initialBalance;
        }

        public decimal Balance => _balance;

        public void Deposit(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Deposit amount must be greater than zero.");
            _balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Withdrawal amount must be greater than zero.");

            if (_balance >= amount)
            {
                _balance -= amount;
                return true;
            }
            return false;
        }
    }
}
