using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem.Logic.Email
{
    public interface IEmailProcessor
    {
        void SendEmail(string email, string message);
    }
}
