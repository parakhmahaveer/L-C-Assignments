using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisorCounter.Services.Interface
{
    public interface IDivisorAnalyzer
    {
        int CountMatchingDivisorPairs(int inputNumber);
    }
}
