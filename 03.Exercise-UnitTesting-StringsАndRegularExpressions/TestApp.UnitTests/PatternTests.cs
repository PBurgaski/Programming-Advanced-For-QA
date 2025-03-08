using System;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PatternTests
{
    [TestCase("sad", 3, "sAdsAdsAd")]
    [TestCase("sad", 2, "sAdsAd")]
    [TestCase("SaD", 3, "sAdsAdsAd")]
    [TestCase("sAd", 3, "sAdsAdsAd")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        string input = string.Empty;
        int repFactor = 3;

        //Act & Assert
        var ex = Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repFactor));
        Assert.That(ex.Message, Is.EqualTo("Input string cannot be empty, and repetition factor must be positive."));
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "sad";
        int repFactor = -3;

        //Act & Assert
        var ex = Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repFactor));
        Assert.That(ex.Message, Is.EqualTo("Input string cannot be empty, and repetition factor must be positive."));
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "sad";
        int repFactor = 0;

        //Act & Assert
        var ex = Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repFactor));
        Assert.That(ex.Message, Is.EqualTo("Input string cannot be empty, and repetition factor must be positive."));
    }
}
