namespace BrainStormLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Smallest Positive Number");
                Console.WriteLine("2. Common Values");
                Console.WriteLine("3. Sum of Pairs");
                Console.WriteLine("4. Reoccuring characters");
                Console.WriteLine("5. Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ArrayManipulation.GetSmallestPositive();
                        break;
                    case "2":
                        ArrayManipulation.GetCommonIntegers();
                        break;
                    case "3":
                        ArrayManipulation.GetPairsBySum();
                        break;
                    case "4":
                        ArrayManipulation.GetRedundantCharacters();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}