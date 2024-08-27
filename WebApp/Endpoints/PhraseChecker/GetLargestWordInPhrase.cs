using Microsoft.AspNetCore.Mvc;
using StringManipulator.Models.Phrase;
using StringManipulator.Models.Phrase.Response;

namespace StringManipulator.Endpoints.StringManipulator;
public static partial class StringManipulatorEndpoints
{
    [ProducesResponseType(typeof(GetPhraseWordResponse), StatusCodes.Status200OK)]
    private static IResult GetLargestWordInPhrase(string phrase)
    {
        if (string.IsNullOrEmpty(phrase))
            return Results.Empty;

        CheckLargestWordPhraseModel model = new(phrase);

        return Results.Ok(new GetPhraseWordResponse(model.GetPhraseWord()));
    }
}
