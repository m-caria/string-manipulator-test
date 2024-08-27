using StringManipulator.Models.Phrase;

namespace StringManipulator.Test.Models;
public class CheckLargestWordPhraseModelTest
{
    [Fact]
    public void GetPhraseWord_ShouldReturnNull_WhenPhraseIsInvalid()
    {
        // Arrange
        CheckLargestWordPhraseModel model = new(string.Empty);

        // Act
        string? result = model.GetPhraseWord();

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void GetPhraseWord_ShouldReturnLargestWord_WhenPhraseIsValid()
    {
        // Arrange
        CheckLargestWordPhraseModel model = new("The largest word in phrase");

        // Act
        string? result = model.GetPhraseWord();

        // Assert
        Assert.Equal("largest", result);
    }

    [Fact]
    public void GetPhraseWord_ShouldReturnLargestWord_WhenPhraseContainsSpecialCharacters()
    {
        // Arrange
        var model = new CheckLargestWordPhraseModel("Hello World!");

        // Act
        string? result = model.GetPhraseWord();

        // Assert
        Assert.Equal("Hello", result);
    }

    [Fact]
    public void GetPhraseWord_ShouldReturnFirstLargestWord_WhenTwoWordsWithSameLength()
    {
        // Arrange
        var model = new CheckLargestWordPhraseModel("World Hello");

        // Act
        string? result = model.GetPhraseWord();

        // Assert
        Assert.Equal("World", result);
    }
}
