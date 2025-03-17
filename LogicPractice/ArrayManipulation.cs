using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPractice
{
    internal class ArrayManipulation
    {
        public static void GetSmallestPositive()
        {
            int numberOfElements;

            Console.WriteLine("Enter the number of elements you want to enter: ");
            numberOfElements = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[numberOfElements];
            Console.WriteLine("Enter the numbers: \n");

            for (int i = 0; i < numberOfElements; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Smallest Positive number: ");

            for (int number = 1; number <= numberOfElements + 1; number++)
            {
                if (!array.Contains(number))
                {
                    Console.WriteLine($"{number}");
                    break;
                }
            }
            Console.ReadLine();
        }

        public static void GetCommonIntegers()
        {
            int numberOfElements;

            Console.WriteLine("Enter the number of elements you want to enter: ");
            numberOfElements = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int[] array1 = new int[numberOfElements];
            int[] array2 = new int[numberOfElements];
            int[] array3 = new int[numberOfElements];

            Console.WriteLine("Enter the numbers for Array 1: \n");

            for (int i = 0; i < numberOfElements; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the numbers for Array 2: \n");

            for (int i = 0; i < numberOfElements; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the numbers for Array 3: \n");

            for (int i = 0; i < numberOfElements; i++)
            {
                array3[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nCommon Numbers in 3 arrays are: ");
            foreach (int number in array1)
            {
                if (array2.Contains(number) && array3.Contains(number))
                {
                    Console.WriteLine(number);
                }
            }
            Console.ReadLine();
        }

        public static void GetPairsBySum()
        {
            int numberOfElements;

            Console.WriteLine("Enter the number of elements you want to enter: ");
            numberOfElements = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[numberOfElements];
            Console.WriteLine("Enter the numbers: \n");

            for (int i = 0; i < numberOfElements; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Dictionary<int, int> pairs = new Dictionary<int, int>();

            foreach (int number1 in array)
            {
                foreach(int number2 in array)
                {
                    if (number1 + number2 == 10 && pairs.ContainsKey(number1) && pairs.ContainsValue(number2))
                    {
                        pairs.Add(number1, number2);
                    }
                }
            }

            foreach(var pair in pairs)
            {
                Console.WriteLine($"{pair.Key}, {pair.Value}");
            }
            Console.ReadLine();
        }

        public static void GetRedundantCharacters()
        {
            string word;
            Console.WriteLine("Enter the word: ");
            word = Console.ReadLine().ToLower();

            char[] characters = word.ToCharArray();
            Dictionary<char, int> charWithIteration = new Dictionary<char, int>();

            foreach(char character in characters)
            {
                if (charWithIteration.ContainsKey(character))
                {
                    charWithIteration[character]++;
                }
                else
                {
                    charWithIteration[character] = 1;
                }
            }

            foreach (var charIteration in charWithIteration)
            {
                Console.WriteLine($"{charIteration.Key} - {charIteration.Value}");
            }
        }
    }
}
