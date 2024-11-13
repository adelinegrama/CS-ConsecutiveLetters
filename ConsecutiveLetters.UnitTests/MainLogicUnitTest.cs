using System;
using ConsecutiveLetters;

namespace ConsecutiveLetters.UnitTests;

[TestClass]
public class MainLogicUnitTest
{
    [TestMethod]
    [DynamicData(nameof(GetTestMainLogic), DynamicDataSourceType.Method)]
    public void TestMainLogic(string input, string expected)
    {
        ConsecutiveLettersFunctions consecutiveLettersFunctions = new ConsecutiveLettersFunctions();
        var actual = consecutiveLettersFunctions.MainLogic(input);

        Assert.AreEqual(expected, actual);
    }

    private static IEnumerable<object[]> GetTestMainLogic()
    {
        yield return new object[] { "programmer", "Your word has consecutive letters!" };
        yield return new object[] { "program", "Your word has no consecutive letters!" };
        yield return new object[] { "green", "Your word has consecutive letters!" };
        yield return new object[] { "red", "Your word has no consecutive letters!" };
        yield return new object[] { "abyss", "Your word has consecutive letters!" };
        yield return new object[] { "drop", "Your word has no consecutive letters!" };
        yield return new object[] { "bottom", "Your word has consecutive letters!" };
        yield return new object[] { "top", "Your word has no consecutive letters!" };
        yield return new object[] { "follower", "Your word has consecutive letters!" };
        yield return new object[] { "leader", "Your word has no consecutive letters!" };
    }
}