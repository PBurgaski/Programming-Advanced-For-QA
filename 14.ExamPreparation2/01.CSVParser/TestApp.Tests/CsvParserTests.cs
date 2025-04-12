using System;
using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        // Arrange
        string input = string.Empty;
        string[] expected = Array.Empty<string>();

        // Act
        string[] result = CsvParser.ParseCsv(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        // Arrange
        string input = "SoftUni";
        string[] expected = new string[]
        {
            "SoftUni"
        };

        // Act
        string[] result = CsvParser.ParseCsv(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        // Arrange
        string input = "SoftUni,Burgaski,QA";
        string[] expected = new string[]
        {
            "SoftUni" , "Burgaski", "QA"
        };

        // Act
        string[] result = CsvParser.ParseCsv(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        // Arrange
        string input = " ";
        string[] expected = new string[]
        {
            ""
        };

        // Act
        string[] result = CsvParser.ParseCsv(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
