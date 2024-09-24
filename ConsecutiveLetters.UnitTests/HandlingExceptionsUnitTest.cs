using System;
using ConsecutiveLetters;

namespace ConsecutiveLetters.UnitTests;

[TestClass]
public class HandlingExceptionsUnitTest
{
    [TestMethod]
    public void Validate_IsNull()
    {
        ConsecutiveLettersFunctions consecutiveLettersFunctions = new ConsecutiveLettersFunctions();
        string? word = null;
        var exceptionNull = Assert.ThrowsException<ArgumentException>(() => consecutiveLettersFunctions.Validate(word));
        Assert.AreEqual("Please, enter a word! It cannot be null, empty or white space!", exceptionNull.Message);
    }

    [TestMethod]
    public void Validate_IsEmpty()
    {
        ConsecutiveLettersFunctions consecutiveLettersFunctions = new ConsecutiveLettersFunctions();
        string word = "";
        var exceptionEmpty = Assert.ThrowsException<ArgumentException>(() => consecutiveLettersFunctions.Validate(word));
        Assert.AreEqual("Please, enter a word! It cannot be null, empty or white space!", exceptionEmpty.Message);
    }

    [TestMethod]
    public void Validate_IsWhiteSpace()
    {
        ConsecutiveLettersFunctions consecutiveLettersFunctions = new ConsecutiveLettersFunctions();
        string word = "  ";
        var exceptionWhiteSpace = Assert.ThrowsException<ArgumentException>(() => consecutiveLettersFunctions.Validate(word));
        Assert.AreEqual("Please, enter a word! It cannot be null, empty or white space!", exceptionWhiteSpace.Message);
    }

    [TestMethod]
    public void Validate_LengthIsOne()
    {
        ConsecutiveLettersFunctions consecutiveLettersFunctions = new ConsecutiveLettersFunctions();
        string word = "w";
        var exceptionLength = Assert.ThrowsException<ArgumentException>(() => consecutiveLettersFunctions.Validate(word));
        Assert.AreEqual("Enter a word that is at least two characters long!", exceptionLength.Message);
    }

    [TestMethod]
    public void Validate_LengthIsTwo()
    {
        ConsecutiveLettersFunctions consecutiveLettersFunctions = new ConsecutiveLettersFunctions();
        string word = "wo";
        var exceptionLength = Assert.ThrowsException<ArgumentException>(() => consecutiveLettersFunctions.Validate(word));
        Assert.AreEqual("Enter a word that is at least two characters long!", exceptionLength.Message);
    }

    [TestMethod]
    public void Validate_Numbers()
    {
        ConsecutiveLettersFunctions consecutiveLettersFunctions = new ConsecutiveLettersFunctions();
        string word = "514";
        var exceptionNumbers = Assert.ThrowsException<ArgumentException>(() => consecutiveLettersFunctions.Validate(word));
        Assert.AreEqual("Please, enter only letters, no digits or non-alphanumeric characters!", exceptionNumbers.Message);
    }

    [TestMethod]
    public void Validate_NonAlphanumericCharacters()
    {
        ConsecutiveLettersFunctions consecutiveLettersFunctions = new ConsecutiveLettersFunctions();
        string word = "|}{[]*&^$.,<>?}";
        var exceptionNonAlphnumericCharacters = Assert.ThrowsException<ArgumentException>(() => consecutiveLettersFunctions.Validate(word));
        Assert.AreEqual("Please, enter only letters, no digits or non-alphanumeric characters!", exceptionNonAlphnumericCharacters.Message);
    }
}