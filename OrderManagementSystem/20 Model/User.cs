using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem.Model
{
    public class User
    {
        public string Name { get; }
        public string Email { get; }

        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"User Name: {Name}, Email: {Email}");
        }
    }
}
