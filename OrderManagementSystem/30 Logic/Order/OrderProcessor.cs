using OrderManagementSystem.Logic.Email;
using OrderManagementSystem.Model;

namespace OrderManagementSystem.Logic.Order
{
    public class OrderProcessor : IOrderProcessor
    {
        private readonly IEmailProcessor _emailService;
        private readonly List<string> _orders = new List<string>();

        public OrderProcessor(IEmailProcessor emailService)
        {
            _emailService = emailService;
        }

        public void ProcessOrder(User user, string product, int quantity, decimal price)
        {
            Model.Order order = new Model.Order(user, product, quantity, price);
            decimal total = order.GetTotalPrice();

            _orders.Add($"Item: {product}, Qty: {quantity}, Total: {total:C}");
            Console.WriteLine("Order Placed!");
            Console.WriteLine($"User: {user.Name}, Item: {product}, Quantity: {quantity}, Total: {total:C}");

            if (quantity > 10)
            {
                Console.WriteLine("Bulk Order Alert!");
            }

            _emailService.SendEmail(user.Email, $"Order placed for {product} with total cost {total:C}");
        }
    }
}
