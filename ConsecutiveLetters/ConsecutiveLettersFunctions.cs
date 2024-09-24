using System;
using System.Text.RegularExpressions;

namespace ConsecutiveLetters
{
    public class ConsecutiveLettersFunctions
    {
        public void Validate(string? userInput)
        {
            if (string.IsNullOrWhiteSpace(userInput) || string.IsNullOrEmpty(userInput))
            {
                throw new ArgumentException("Please, enter a word! It cannot be null, empty or white space!");
            }

            if (userInput.Length <= 2)
            {
                throw new ArgumentException("Enter a word that is at least two characters long!");
            }

            if (Regex.IsMatch(userInput, @"^[\d\W]+$"))
            {
                throw new ArgumentException("Please, enter only letters, no digits or non-alphanumeric characters!");
            }
        }
    }
}