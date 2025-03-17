using OrderManagementSystem.Logic.Payment;
using OrderManagementSystem.Logic.Email;
using OrderManagementSystem.Logic.Order;
using OrderManagementSystem.Model;

namespace OrderManagementSystem
{
    public static class Program
    {
        static void Main(string[] args)
        {
            User user = new User("John", "john@example.com");
            IOrderProcessor orderProcessor = new OrderProcessor(new EmailProcessor());
            orderProcessor.ProcessOrder(user, "Laptop", 3, 700);

            IPaymentProcessor paymentProcessor = new PaymentProcessor();
            paymentProcessor.MakePayment("Credit", 2100, "John Doe", "1234567812345678");
        }
    }
}