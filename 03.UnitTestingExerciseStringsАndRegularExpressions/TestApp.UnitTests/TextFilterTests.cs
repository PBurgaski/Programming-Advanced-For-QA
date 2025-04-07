using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWord = new string[] { };
        string text = "You are so bad!";
        string expected = "You are so bad!";

        // Act
        string result = TextFilter.Filter(bannedWord, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
   

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] bannedWord = new string[]
        {
            "bad"
        };
        string text = "You are so bad!";
        string expected = "You are so ***!";

        // Act
        string result = TextFilter.Filter(bannedWord, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWord = Array.Empty<string>();
        string text = "You are so bad!";
        string expected = "You are so bad!";

        // Act
        string result = TextFilter.Filter(bannedWord, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] bannedWord = new string[]
        {
            "are so"
        };
        string text = "You are so bad!";
        string expected = "You ****** bad!";

        // Act
        string result = TextFilter.Filter(bannedWord, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
