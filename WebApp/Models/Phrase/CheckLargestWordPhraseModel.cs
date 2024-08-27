using StringManipulator.Helpers;

namespace StringManipulator.Models.Phrase;
public record CheckLargestWordPhraseModel(string Phrase) : PhraseModel(Phrase), IPhraseModel
{
    public string? GetPhraseWord()
    {
        if (!IsPhraseValid()) return null;

        string[] words = Phrase.Split(' ');

        string? largestWord = words
            .Select(Regexes.ReplaceSpecialCharacters)
            .OrderByDescending(word => word.Length)
            .FirstOrDefault();

        return largestWord;
    }
}
