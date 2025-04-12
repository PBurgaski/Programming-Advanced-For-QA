using System;
using NUnit.Framework;

using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        // Arrange
        string product = "banana";
        double price = 3.60;
        int quantity = 3;
        string expected = $"Product Inventory:" + Environment.NewLine + "banana - Price: $3.60 - Quantity: 3";


        // Act
         this._inventory.AddProduct(product, price, quantity);
        string result = this._inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        // Arrange
        string expected = "Product Inventory:";

        // Act
        string result = this._inventory.DisplayInventory();

        // Assert 
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // Arrange
        string product = "banana";
        string product2 = "apple";
        string product3 = "orange";
        double price = 3.60;
        double price2 = 1.60;
        double price3 = 2.60;
        int quantity = 3;
        int quantity2 = 4;
        int quantity3 = 2;
        string expected = $"Product Inventory:" + Environment.NewLine + "banana - Price: $3.60 - Quantity: 3" 
            + Environment.NewLine +
             "apple - Price: $1.60 - Quantity: 4"
            + Environment.NewLine +
             "orange - Price: $2.60 - Quantity: 2";


        // Act
        this._inventory.AddProduct(product, price, quantity);
        this._inventory.AddProduct(product2, price2, quantity2);
        this._inventory.AddProduct(product3, price3, quantity3);
        string result = this._inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        // Arrange
        double expected = 0;

        // Act
        double result = this._inventory.CalculateTotalValue();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // Arrange
        string product = "banana";
        string product2 = "apple";
        string product3 = "orange";
        double price = 3.60;
        double price2 = 1.60;
        double price3 = 2.60;
        int quantity = 3;
        int quantity2 = 4;
        int quantity3 = 2;
        double expected = 22.400000000000002;


        // Act
        this._inventory.AddProduct(product, price, quantity);
        this._inventory.AddProduct(product2, price2, quantity2);
        this._inventory.AddProduct(product3, price3, quantity3);

        double result = this._inventory.CalculateTotalValue();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

