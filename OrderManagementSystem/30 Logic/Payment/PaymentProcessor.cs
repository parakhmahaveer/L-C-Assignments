using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem.Logic.Payment
{
    public class PaymentProcessor : IPaymentProcessor
    {
        public void MakePayment(string paymentType, decimal amount, string cardName, string cardNumber)
        {
            switch (paymentType)
            {
                case "Credit":
                    Console.WriteLine($"Processing Credit Card payment of {amount:C}");
                    break;
                case "Debit":
                    Console.WriteLine($"Processing Debit Card payment of {amount:C}");
                    break;
                default:
                    Console.WriteLine("Unknown Payment Method");
                    return;
            }

            if (amount > 1000)
            {
                Console.WriteLine("High-value transaction alert!");
            }

            string maskedCardNumber = cardNumber.Substring(cardNumber.Length - 4);
            Console.WriteLine($"Payment Done for {cardName} (Card Ending: {maskedCardNumber})");
        }
    }
}
