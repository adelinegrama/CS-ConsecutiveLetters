using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsecutiveLetters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Task 71
            //check if a given string contains two similar consecutive letters

            Console.WriteLine("Enter a string that may or may not contain consecutive letters:");
            
            bool UserInput(string? userInput)
            {
                for (int i = 1; i < userInput?.Length; i++)
                {
                    if (userInput[i] == userInput[i - 1])
                    {
                        return true;
                    }
                }
                return false;
            }

            var result = UserInput(Console.ReadLine());
            Console.WriteLine(result);
        }
    }
}