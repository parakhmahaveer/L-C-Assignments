namespace MoodleAssignment1._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Roll the Dice");
                Console.WriteLine("2. Guess the Number");
                Console.WriteLine("3. Check Armstrong Number");
                Console.WriteLine("4. Exit");
                string choice = Console.ReadLine();

                var numberIdentifier = new NumberIdentifier();
                switch (choice)
                {   
                    case "1":
                        var diceRoller = new DiceRoller();
                        diceRoller.RollTheDice();
                        break;
                    case "2":
                        numberIdentifier.GuessTheNumber();
                        break;
                    case "3":
                        numberIdentifier.CheckArmstrongNumber();
                        break;
                    case "4":
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