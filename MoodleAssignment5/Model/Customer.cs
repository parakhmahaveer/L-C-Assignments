using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodleAssignment5.Model
{
    public class Customer
    {
        public string FirstName { get; }
        public string LastName { get; }
        public Wallet Wallet;

        public Customer(string firstName, string lastName, decimal initialBalance)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            Wallet = new Wallet(initialBalance);
        }

        public bool MakePayment(decimal amount) => Wallet.Withdraw(amount);
        public decimal GetBalance() => Wallet.Balance;
    }
}
