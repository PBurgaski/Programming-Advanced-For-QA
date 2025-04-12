using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        // Arrange
        Dictionary<string, int> input = new Dictionary<string, int>();
        input.Add("banana", 3);
        input.Add("apple", 2);
        input.Add("orange", 5);
        string fruitName = "orange";
        int expected = 5;

        // Act
        int result = Fruits.GetFruitQuantity(input, fruitName);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> input = new Dictionary<string, int>();
        input.Add("banana", 3);
        input.Add("apple", 2);
        input.Add("orange", 5);
        string fruitName = "orangee";
        int expected = 0;

        // Act
        int result = Fruits.GetFruitQuantity(input, fruitName);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> input = new Dictionary<string, int>();
        string fruitName = "orange";
        int expected = 0;

        // Act
        int result = Fruits.GetFruitQuantity(input, fruitName);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> input = null;
        string fruitName = "orange";
        int expected = 0;

        // Act
        int result = Fruits.GetFruitQuantity(input, fruitName);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> input = new Dictionary<string, int>();
        input.Add("banana", 3);
        input.Add("apple", 2);
        input.Add("orange", 5);
        string fruitName = null;
        int expected = 0;

        // Act
        int result = Fruits.GetFruitQuantity(input, fruitName);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
