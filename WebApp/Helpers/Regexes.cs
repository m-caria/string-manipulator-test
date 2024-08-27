using System.Text.RegularExpressions;

namespace StringManipulator.Helpers;
public static partial class Regexes
{
    [GeneratedRegex("[^a-zA-Z0-9]")]
    public static partial Regex AllowedCharactersAndDigits();
    public static string ReplaceSpecialCharacters(string input) => AllowedCharactersAndDigits().Replace(input, "");
}
