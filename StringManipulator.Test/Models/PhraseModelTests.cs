using StringManipulator.Models.Phrase;

namespace StringManipulator.Test.Models;
public class PhraseModelTests
{
    [Fact]
    public void IsPhraseValid_ShouldReturnFalse_WhenPhraseIsEmpty()
    {
        // Arrange
        PhraseModel model = new(string.Empty);

        // Act
        bool result = model.IsPhraseValid();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPhraseValid_ShouldReturnTrue_WhenPhraseIsNotEmpty()
    {
        // Arrange
        PhraseModel model = new("Test phrase");

        // Act
        bool result = model.IsPhraseValid();

        // Assert
        Assert.True(result);
    }
}
