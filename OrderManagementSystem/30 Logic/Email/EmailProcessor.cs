using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem.Logic.Email
{
    public class EmailProcessor : IEmailProcessor
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine($"Sending email to: {email}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
