using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ArticleTests
{
    private Article  _article;
    [SetUp]
    public void Article()
    {
        this._article = new Article();
    }

    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] input = new string[] 
        {
            "Article Content1 Author1",
            "Article2 Content2 Author2",
            "Article3 Content3 Author3",
        };

        // Act
        Article result = this._article.AddArticles(input);

        // Assert
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));
        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Article"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange
        string[] input = new string[]
        {
            "Article2 Content1 Author1",
            "Article3 Content2 Author2",
            "Article1 Content3 Author3",
        };
        string criteria = "title";
        string expected = $"Article1 - Content3: Author3"
            + Environment.NewLine + "Article2 - Content1: Author1"
            + Environment.NewLine + "Article3 - Content2: Author2";

        // Act
        Article needednResult = this._article.AddArticles(input);
        string result = this._article.GetArticleList(needednResult, criteria);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        string[] input = new string[]
        {
            "Article2 Content1 Author1",
            "Article3 Content2 Author2",
            "Article1 Content3 Author3",
        };
        string criteria = "invalid";
        string expected = string.Empty;

        // Act
        Article needednResult = this._article.AddArticles(input);
        string result = this._article.GetArticleList(needednResult, criteria);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
