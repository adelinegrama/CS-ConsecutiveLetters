using System;

namespace ConsecutiveLetters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Task 71
            //check if a given word contains two similar consecutive letters

            Console.WriteLine("Enter a word that may or may not contain consecutive letters:");

            try
            {
                var userInput = Console.ReadLine();
                ConsecutiveLettersFunctions consecutiveLettersFunctions = new ConsecutiveLettersFunctions();
                consecutiveLettersFunctions.Validate(userInput);

                bool hasConsecutiveLetters = false;
                for (int i = 1; i < userInput?.Length; i++)
                {
                    if (userInput[i] == userInput[i - 1])
                    {
                        hasConsecutiveLetters = true;
                        break;
                    }
                    else
                    {
                        hasConsecutiveLetters = false;
                    }
                }

                if (hasConsecutiveLetters)
                {
                    Console.WriteLine("Your word has consecutive letters!");
                }
                else
                {
                    Console.WriteLine("Your word has no consecutive letters!");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}