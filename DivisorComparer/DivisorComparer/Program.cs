using DivisorComparer.Logic.Services;

namespace DivisorComparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var divisorService = new DivisorService();

            Console.Write("Enter the number of test cases: ");
            if (!int.TryParse(Console.ReadLine(), out int testCaseCount) || testCaseCount <= 0)
            {
                Console.WriteLine("Invalid number of test cases.");
                return;
            }

            for (int testCaseIndex = 0; testCaseIndex < testCaseCount; testCaseIndex++)
            {
                Console.Write($"Enter value for test case {testCaseIndex + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int inputNumber) && inputNumber > 0)
                {
                    int matchingPairCount = divisorService.CountMatchingDivisorPairs(inputNumber);
                    Console.WriteLine($"Result: {matchingPairCount}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
            }
        }
    }
}