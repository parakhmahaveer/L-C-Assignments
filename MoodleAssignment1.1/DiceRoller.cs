using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodleAssignment1._1
{
    public class DiceRoller
    {
        public void RollTheDice()
        {
            Random randomNumber = new Random();
            bool rolling = true;
            while (rolling)
            {
                Console.WriteLine("Ready to roll? Enter Q to Quit");
                string input = Console.ReadLine();
                if (input.ToLower() != "q")
                {
                    int number = randomNumber.Next(1, 7);
                    Console.WriteLine($"You have rolled a {number}");
                }
                else
                {
                    rolling = false;
                }
            }
        }
    }
}
