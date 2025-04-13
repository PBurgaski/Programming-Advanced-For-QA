using System;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace TestApp.Tests;

public class LetterTypeCounterTests
{
    [Test]
    public void Test_CountLetterTypes_EmptyString_ReturnEmptyDictionary()
    {
        // Arrange
        string input = string.Empty;

        // Act
        Dictionary<string, int> result = LetterTypeCounter.CountLetterTypes(input);

        // Assert
        CollectionAssert.IsEmpty(result);
    }

    [Test]
    public void Test_CountLetterTypes_NonLetterString_ReturnNonLetterCountOnly()
    {
        // Arrange
        string input = "!@#456";
        Dictionary<string, int> expected = new Dictionary<string, int>() { };
        expected.Add("non-letter", 6);


        // Act
        Dictionary<string, int> result = LetterTypeCounter.CountLetterTypes(input);

        // Assert
        CollectionAssert.AreEquivalent(expected, result);
    }

    [Test]
    public void Test_CountLetterTypes_NoOddLetterString_ReturnEvenAndNonLetterCount()
    {
        // Arrange
        string input = "b!@#456b";
        Dictionary<string, int> expected = new Dictionary<string, int>() { };
        expected.Add("even letter", 2);
        expected.Add("non-letter", 6);


        // Act
        Dictionary<string, int> result = LetterTypeCounter.CountLetterTypes(input);

        // Assert
        CollectionAssert.AreEquivalent(expected, result);
    }

    [Test]
    public void Test_CountLetterTypes_NoEvenLetterString_ReturnOddAndNonLetterCount()
    {
        // Arrange
        string input = "a!@#456c";
        Dictionary<string, int> expected = new Dictionary<string, int>() { };
        expected.Add("odd letter", 2);
        expected.Add("non-letter", 6);


        // Act
        Dictionary<string, int> result = LetterTypeCounter.CountLetterTypes(input);

        // Assert
        CollectionAssert.AreEquivalent(expected, result);
    }

    [Test]
    public void Test_CountLetterTypes_AllTypeOfLetterString_ReturnEvenOddAndNonLetterCount()
    {
        // Arrange
        string input = "b!@#456bac";
        Dictionary<string, int> expected = new Dictionary<string, int>() { };
        expected.Add("even letter", 2);
        expected.Add("odd letter", 2);
        expected.Add("non-letter", 6);


        // Act
        Dictionary<string, int> result = LetterTypeCounter.CountLetterTypes(input);

        // Assert
        CollectionAssert.AreEquivalent(expected, result);
    }
}
