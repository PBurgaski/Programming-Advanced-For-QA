using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;
        int position = 2;
        string expected = string.Empty;

        // Act
        string result = StringRotator.RotateRight(input, position);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        // Arrange
        string input = "pizza";
        int position = 0;
        string expected = "pizza";

        // Act
        string result = StringRotator.RotateRight(input, position);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "pizza";
        int position = 2;
        string expected = "zapiz";

        // Act
        string result = StringRotator.RotateRight(input, position);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "pizza";
        int position = -3;
        string expected = "zzapi";

        // Act
        string result = StringRotator.RotateRight(input, position);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arrange
        string input = "pizza";
        int position = 6;
        string expected = "apizz";

        // Act
        string result = StringRotator.RotateRight(input, position);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
