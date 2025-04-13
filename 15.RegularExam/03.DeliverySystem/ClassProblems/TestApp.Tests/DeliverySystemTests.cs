using System;
using System.Text;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests;

public class DeliverySystemTests
{
    private DeliverySystem _deliverySystem;
    [SetUp]
    public void SetUp()
    {
        this._deliverySystem = new DeliverySystem();
    }
    [Test]
    public void Test_Constructor_CheckInitialEmptyDeliveryCollectionAndCount()
    {
        // Arrange
        List<string> expected = new  List<string> { };
        int expected2 = 0;

        // Act
        List<string> result = this._deliverySystem.GetAllDeliveriesInProgress();
        int result2 = this._deliverySystem.DeliveriesInProgressCount;

        // Assert

        Assert.That(result, Is.EqualTo(expected));
        Assert.That(result2, Is.EqualTo(expected2));
        CollectionAssert.IsEmpty(result);

    }

    [Test]
    public void Test_AddDelivery_ValidItem_AddNewItemForDelivery()
    {
        // Arrange
        string input = "Car";
        string input2 = "Truck";
        List<string> expected = new List<string> { };
        expected.Add("Car");
        expected.Add("Truck");

        // Act
        this._deliverySystem.AddDelivery(input);
        this._deliverySystem.AddDelivery(input2);
        List<string> result = this._deliverySystem.GetAllDeliveriesInProgress(); 

        // Assert

        Assert.That(result, Is.EqualTo(expected));
        Assert.That(result.Any(), Is.True);
        CollectionAssert.AreEquivalent(expected, result);

    }

    [Test]
    [TestCase(null)]
    [TestCase("")]
    [TestCase("   ")]
    public void Test_AddDelivery_NullOrEmptyItem_ThrowsArgumentException(string input)
    {
        // Arrange, Act & Assert
        
        Assert.That(() => this._deliverySystem.AddDelivery(input), Throws.ArgumentException);

    }

    [Test]
    public void Test_FinishDelivery_ValidItem_RemoveExistingItemAsDelivered()
    {
        // Arrange
        string input = "Car";
        List<string> expected = new List<string> { };

        // Act
        this._deliverySystem.AddDelivery(input);
        this._deliverySystem.FinishDelivery(input);
        List<string> result = this._deliverySystem.GetAllDeliveriesInProgress();

        // Assert

        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    [TestCase(null)]
    [TestCase("")]
    [TestCase("   ")]
    [TestCase("NonExistingItem")]
    public void Test_FinishDelivery_NullOrEmptyOrNonExistingItem_ThrowsArgumentException(string input)
    {

        // Arrange, Act & Assert
        Assert.That(() => this._deliverySystem.FinishDelivery(input), Throws.ArgumentException);

    }

    [Test]
    public void Test_GetAllDeliveriesInProgress_AddAndFinishDeliveries_ReturnExpectedDeliveryCollection()
    {
        // Arrange
        string input = "Car";
        string input2 = "Truck";
        List<string> expected = new List<string> {  };

        // Act
        this._deliverySystem.AddDelivery(input);
        this._deliverySystem.AddDelivery(input2);
        this._deliverySystem.FinishDelivery(input);
        this._deliverySystem.FinishDelivery(input2);
        List<string> result = this._deliverySystem.GetAllDeliveriesInProgress();

        // Assert

        Assert.That(result, Is.EqualTo(expected));

    }
}

