using MoodleAssignment5.Model;
using MoodleAssignment5.Service;

namespace MoodleAssignment5
{
    public class Program
    {
        public static void Main()
        {
            Customer myCustomer = new Customer("John", "Doe", 10.00m);
            PaymentService paymentService = new PaymentService();

            decimal payment = 2.00m;

            if (paymentService.ProcessPayment(myCustomer, payment))
            {
                Console.WriteLine("Payment successful. Remaining balance: " + myCustomer.Wallet.Balance);
            }
            else
            {
                Console.WriteLine("Insufficient funds. Please come back later!");
            }
        }
    }
}
