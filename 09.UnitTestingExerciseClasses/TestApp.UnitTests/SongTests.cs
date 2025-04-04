using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class SongTests
{
    private Song _song;

    [SetUp]
    public void Setup()
    {
        this._song = new();
    }

    [Test]
    public void Test_AddAndListSongs_ReturnsAllSongs_WhenWantedListIsAll()
    {
        // Arrange
        string[] songs = { "Pop_Song1_3:30", "Rock_Song2_4:15", "Pop_Song3_3:00" };
        string expected = $"Song1{Environment.NewLine}Song2{Environment.NewLine}Song3";
        string playlist = "all";

        // Act
        string result = this._song.AddAndListSongs(songs, playlist);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndListSongs_ReturnsFilteredSongs_WhenWantedListIsSpecific()
    {
        // Arrange
        string[] songs = { "Pop_Song1_3:30", "Rock_Song2_4:15", "Pop_Song3_3:00" };
        string expected = $"Song1{Environment.NewLine}Song3";
        string playlist = "Pop";

        // Act
        string result = this._song.AddAndListSongs(songs, playlist);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndListSongs_ReturnsEmptyString_WhenNoSongsMatchWantedList()
    {
        // Arrange
        string[] songs = { "Pop_Song1_3:30", "Rock_Song2_4:15", "Pop_Song3_3:00" };
        string expected = string.Empty;
        string playlist = "Jazz";

        // Act
        string result = this._song.AddAndListSongs(songs, playlist);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
