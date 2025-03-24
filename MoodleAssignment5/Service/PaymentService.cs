using MoodleAssignment5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodleAssignment5.Service
{
    public class PaymentService
    {
        public bool ProcessPayment(Customer customer, decimal amount)
        {
            if (customer == null) throw new ArgumentNullException(nameof(customer));
            return customer.MakePayment(amount);
        }
    }
}
