using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text = "";
        List<string> expected = new List<string>();

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string text = "text";
        List<string> expected = new List<string>();

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string text = "https://softuni.bg";
        List<string> expected = new List<string>
        {
            "https://softuni.bg"
        };

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string text = "https://softuni.bg https://judge.softuni.org https://regex101.com/";
        List<string> expected = new List<string>
        {
            "https://softuni.bg",
            "https://judge.softuni.org",
            "https://regex101.com"
        };

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        string text = "Check this site https://softuni.bg and this one https://judge.softuni.org";
        List<string> expected = new List<string>
        {
            "https://softuni.bg",
            "https://judge.softuni.org"
        };

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
