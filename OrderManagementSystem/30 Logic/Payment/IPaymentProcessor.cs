using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem.Logic.Payment
{
    public interface IPaymentProcessor
    {
        void MakePayment(string paymentType, decimal amount, string cardName, string cardNumber);
    }
}
