namespace StringManipulator.Models.Phrase;
public record PhraseModel(string Phrase)
{
    public bool IsPhraseValid() => !string.IsNullOrWhiteSpace(Phrase);
}

public interface IPhraseModel
{
    string? GetPhraseWord();
}
