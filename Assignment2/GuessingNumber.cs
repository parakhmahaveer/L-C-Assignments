namespace MoodleAssignment2_Functions
{
    public class GuessingNumber
    {
        private readonly Random _random = new Random();
        private int targetNumber;
        private int guessCount;

        public void GuessNumber()
        {
            try
            {
                targetNumber = _random.Next(1, 101);
                guessCount = 0;
                bool guessedCorrectly = false;

                Console.Write("Guess a number between 1 and 100: ");
                string input = Console.ReadLine();

                while (!guessedCorrectly)
                {
                    if (!IsValidGuess(input, out int guess))
                    {
                        Console.Write("Invalid input. Please enter a number between 1 and 100: ");
                        input = Console.ReadLine();
                        continue;
                    }

                    guessCount++;
                    guessedCorrectly = AnalyzeGuess(guess);

                    if (!guessedCorrectly)
                    {
                        Console.Write("Guess again: ");
                        input = Console.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool IsValidGuess(string input, out int number)
        {
            return int.TryParse(input, out number) && number >= 1 && number <= 100;
        }

        private bool AnalyzeGuess(int guess)
        {
            if (guess < targetNumber)
            {
                Console.WriteLine("Too low.");
                return false;
            }
            else if (guess > targetNumber)
            {
                Console.WriteLine("Too high.");
                return false;
            }
            else
            {
                Console.WriteLine($"You guessed it in {guessCount} attempts!");
                return true;
            }
        }
    }
}