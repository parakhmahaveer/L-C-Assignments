namespace OrderManagementSystem.Model
{
    public class Order
    {
        public User Customer { get; }
        public string Product { get; }
        public int Quantity { get; }
        public decimal Price { get; }

        public Order(User customer, string product, int quantity, decimal price)
        {
            Customer = customer;
            Product = product;
            Quantity = quantity;
            Price = price;
        }

        public decimal GetTotalPrice()
        {
            decimal total = Quantity * Price;
            if (Quantity > 5) total *= 0.85m; // 15% discount for bulk orders
            return total;
        }
    }
}
