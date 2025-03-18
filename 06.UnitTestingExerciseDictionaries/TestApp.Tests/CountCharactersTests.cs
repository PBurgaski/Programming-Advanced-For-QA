using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new List<string> { "", "", "" };
        string expected = string.Empty;

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string> { "a" };
        string expected = "a -> 1";


        // Act
        string result = CountCharacters.Count(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string> { "aa", "Aa", "Bb", "bb", "c" };
        string expected =
            $"a -> 3"
            + Environment.NewLine
            + "A -> 1"
            + Environment.NewLine
            + "B -> 1"
            + Environment.NewLine
            + "b -> 3"
            + Environment.NewLine
            + "c -> 1";

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string> { "@#$" };
        string expected = $"@ -> 1"
                          + Environment.NewLine +
                          "# -> 1"
                          + Environment.NewLine +
                          "$ -> 1";


        // Act
        string result = CountCharacters.Count(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
