using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_ErrorHandling.Models
{
    public class Account
    {
        public string CardNumber { get; set; }
        public string Pin { get; set; }
        public decimal Balance { get; set; }
        public decimal DailyLimit { get; set; }
        public int InvalidPinAttempts { get; set; }
        public bool IsBlocked { get; set; }
        public decimal DailyWithdrawal { get; set; }
    }
}
