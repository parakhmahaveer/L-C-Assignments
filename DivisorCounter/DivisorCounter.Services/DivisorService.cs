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
            int count = 0;
            for (int index = 1; index <= Math.Sqrt(number); index++)
            {
                if (number % index == 0)
                {
                    count += (index == number / index) ? 1 : 2;
                }
            }
            return count;
        }
    }
}
