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
                //consecutiveLettersFunctions.MainLogic(userInput);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}