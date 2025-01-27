namespace MoodleAssignment1._1
{
    public class NumberIdentifier
    {
        //Identify Armstrong Number
        public void CheckArmstrongNumber()
        {
            Console.WriteLine("Please enter the number to check for Armstrong:");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                int sumOfNumbers = 0;
                int cache = number;
                int digits = 0;

                while (cache > 0)
                {
                    digits++;
                    cache /= 10;
                }

                cache = number;
                while (cache > 0)
                {
                    int remainder = cache % 10;
                    sumOfNumbers += (int)Math.Pow(remainder, digits);
                    cache /= 10;
                }

                if (sumOfNumbers == number)
                {
                    Console.WriteLine($"{number} is an Armstrong number.");
                }
                else
                {
                    Console.WriteLine($"{number} is not an Armstrong number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        public void GuessTheNumber()
        {
            Random randomNumber = new Random(); 
            int number = randomNumber.Next(1, 101); // Fetch random number
            bool guessed = false;
            int attempts = 0;

            while (!guessed)
            {
                Console.WriteLine("Guess a number between 1 and 100:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int guessedNumber) && guessedNumber >= 1 && guessedNumber <= 100)
                {
                    attempts++;
                    if (guessedNumber < number)
                    {
                        Console.WriteLine("Too low. Guess again.");
                    }
                    else if (guessedNumber > number)
                    {
                        Console.WriteLine("Too high. Guess again.");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it in {attempts} guesses!");
                        guessed = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                }
            }
        }
    }
}
