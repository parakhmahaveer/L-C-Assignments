using Microsoft.EntityFrameworkCore;

namespace MoodleAssignment2_Functions.DAL
{
    public class CustomerDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerID = 1, CompanyName = "New Company 1", ContactName = "John", Country = "USA" },
                new Customer { CustomerID = 2, CompanyName = "New Company 2", ContactName = "Brijbhusan", Country = "India" },
                new Customer { CustomerID = 3, CompanyName = "New Company 3", ContactName = "Swami", Country = "Sri Lanka" }
            );
        }
    }
}
