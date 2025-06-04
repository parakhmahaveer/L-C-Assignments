using DivisorCounter.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisorCounter.Services
{
    public class DivisorAnalyzer : IDivisorAnalyzer
    {
        private readonly IDivisorService _divisorService;

        public DivisorAnalyzer(IDivisorService divisorService)
        {
            _divisorService = divisorService;
        }

        public int CountMatchingDivisorPairs(int inputNumber)
        {
            int count = 0;
            for (int index = 1; index < inputNumber; index++)
            {
                if (_divisorService.CountDivisors(index) == _divisorService.CountDivisors(inputNumber - index))
                    count++;
            }
            return count;
        }
    }
}
