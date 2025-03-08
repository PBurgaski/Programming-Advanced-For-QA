using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
   [TestCase("validmail@domain.com")]
   [TestCase("validemail@abv.bg")]
   [TestCase("test@test.test")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange
        bool expected = true;
        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("invalidEmail@bg")]
    [TestCase("@gmail.com")]
    [TestCase("invalid email@gmail.com")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange
        bool expected = false;
        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
