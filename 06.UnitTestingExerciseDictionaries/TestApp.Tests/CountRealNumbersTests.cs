using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] input = new int[] { };

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 1 };
        string expected = "1 -> 1";
        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 1, 1, 2, 2, 3, 3 };
        string expected = $"1 -> 2"
                          + Environment.NewLine +
                          "2 -> 2"
                          + Environment.NewLine +
                          "3 -> 2";
        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { -1, -2, -3, -2 };
        string expected = $"-3 -> 1"
                          + Environment.NewLine +
                          "-2 -> 2"
                          + Environment.NewLine +
                          "-1 -> 1";
        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 0, 0, 0, 0 };
        string expected = "0 -> 4";
        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
