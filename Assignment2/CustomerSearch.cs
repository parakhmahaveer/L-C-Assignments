using MoodleAssignment2_Functions.DAL;
using System.Text;

namespace MoodleAssignment2_Functions
{
    public class CustomerSearch
    {
        private readonly CustomerDbContext _dbContext;

        public CustomerSearch(CustomerDbContext context)
        {
            _dbContext = context;
        }

        public List<Customer> SearchByCountry(string country)
        {
            try
            {
                return _dbContext.Customers
                         .Where(c => c.Country.Contains(country))
                         .OrderBy(c => c.CustomerID)
                         .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Customer> SearchByCompanyName(string company)
        {
            try
            {
                return _dbContext.Customers
                     .Where(c => c.CompanyName.Contains(company))
                     .OrderBy(c => c.CustomerID)
                     .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Customer> SearchByContact(string contact)
        {
            try
            {
                return _dbContext.Customers
                         .Where(c => c.ContactName.Contains(contact))
                         .OrderBy(c => c.CustomerID)
                         .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ExportToCSV(List<Customer> data)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in data)
                {
                    sb.AppendLine($"{item.CustomerID},{item.CompanyName},{item.ContactName},{item.Country}");
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
