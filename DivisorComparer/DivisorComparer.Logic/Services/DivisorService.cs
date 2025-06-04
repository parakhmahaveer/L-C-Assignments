using DivisorComparer.Logic.Services.Interface;

namespace DivisorComparer.Logic.Services
{
    public class DivisorService : IDivisorService
    {

        public int CountMatchingDivisorPairs(int inputNumber)
        {
            int count = 0;
            for (int index = 1; index < inputNumber; index++)
            {
                if (CountDivisors(index) == CountDivisors(inputNumber - index))
                    count++;
            }
            return count;
        }

        // Counts the number of positive divisors of a given number
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
