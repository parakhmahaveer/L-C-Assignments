using OrderManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem.Logic.Order
{
    public interface IOrderProcessor
    {
        void ProcessOrder(User user, string product, int quantity, decimal price);
    }
}
