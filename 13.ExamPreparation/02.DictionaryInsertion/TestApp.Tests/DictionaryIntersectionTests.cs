using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>();
        Dictionary<string, int> dict2 = new Dictionary<string, int>();
        Dictionary<string, int> expectedDict = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.EqualTo(expectedDict));
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {

        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>();
        Dictionary<string, int> dict2 = new Dictionary<string, int>();
        dict2.Add("banana", 3);
        Dictionary<string, int> expectedDict = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.EqualTo(expectedDict));

    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {

        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>();
        dict1.Add("banan", 4);
        Dictionary<string, int> dict2 = new Dictionary<string, int>();
        dict2.Add("banana", 3);
        Dictionary<string, int> expectedDict = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.EqualTo(expectedDict));

    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {

        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>();
        dict1.Add("banana", 3);
        Dictionary<string, int> dict2 = new Dictionary<string, int>();
        dict2.Add("banana", 3);
        Dictionary<string, int> expectedDict = new Dictionary<string, int>();
        expectedDict.Add("banana", 3);


        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.EqualTo(expectedDict));

    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {

        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>();
        dict1.Add("banana", 4);
        Dictionary<string, int> dict2 = new Dictionary<string, int>();
        dict2.Add("banana", 3);
        Dictionary<string, int> expectedDict = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.EqualTo(expectedDict));

    }
}
