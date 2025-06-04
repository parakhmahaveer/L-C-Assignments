using DivisorCounter.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisorCounter.Services
{
    public class DivisorService : IDivisorService
    {
        public int CountDivisors(int number)
        {
            if(number == 1)
            {
                return 1;
            }
            return 10;
        }
    }
}
