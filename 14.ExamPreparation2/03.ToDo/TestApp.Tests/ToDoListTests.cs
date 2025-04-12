using System;

using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }
    
    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        // Arrange
        string title = "Do homework.";
        DateTime dueDate = DateTime.Today; 
        this._toDoList.AddTask(title, dueDate);
        string expected = $"To-Do List:" + Environment.NewLine +
            "[ ] Do homework. - Due: 04/12/2025";

        // Act
        string result = this._toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        // Arrange
        string title = "Do homework.";
        DateTime dueDate = DateTime.Today;
        this._toDoList.AddTask(title, dueDate);
        this._toDoList.CompleteTask(title);
        string expected = $"To-Do List:" + Environment.NewLine +
            "[✓] Do homework. - Due: 04/12/2025";

        // Act
        string result = this._toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        // Arrange
        string title = "Do homework.";
        string missingTitle = "Don't do homework";
        DateTime dueDate = DateTime.Today;
        this._toDoList.AddTask(title, dueDate);


        // Act & Assert
        Assert.That(() => this._toDoList.CompleteTask(missingTitle), Throws.ArgumentException);
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        // Arrange
        string expected = "To-Do List:";

        // Act
        string result = this._toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        // Arrange
        string title = "Do homework.";
        string title2 = "Do project.";
        string title3 = "Do workout.";
        DateTime dueDate = DateTime.Today;
        DateTime dueDate2 = DateTime.Today;
        DateTime dueDate3 = DateTime.Today;
        this._toDoList.AddTask(title, dueDate);
        this._toDoList.AddTask(title2, dueDate2);
        this._toDoList.AddTask(title3, dueDate3);
        string expected = $"To-Do List:" + Environment.NewLine +
            "[ ] Do homework. - Due: 04/12/2025"
            + Environment.NewLine +
            "[ ] Do project. - Due: 04/12/2025"
            + Environment.NewLine +
            "[ ] Do workout. - Due: 04/12/2025";

        // Act
        string result = this._toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
