
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodeSolutions.String;
/// <summary>
/// The word i18n is a common abbreviation of internationalization in the developer community, used instead 
/// of typing the whole word and trying to spell it correctly. Similarly, a11y is an abbreviation of accessibility.
/// Write a function that takes a string and turns any and all "words" (see below) within that string of length 
/// 4 or greater into an abbreviation, following these rules:
/// A "word" is a sequence of alphabetical characters.By this definition, any other character like a space or hyphen
/// (eg. "elephant-ride") will split up a series of lette/rs into two words (eg. "elephanand "ride").
/// The abbreviated version of the word should have the first letter, then the number of removed characters, then the last letter (eg. "elephant ride" => "e6t r2e").
/// </summary>
public static class Abbreviation
{

    public static string InterNationalization(string inputSting)
    {// EXAMPLE -> input: "elephant-rides are really fun!"

        StringBuilder result = new StringBuilder();
        StringBuilder word = new StringBuilder();

        foreach (char c in inputSting)
        {
            if (char.IsLetter(c))
            {
                word.Append(c);
            }
            else
            {
                if (word.Length >= 4)
                {
                    result.Append(AbbreviateWord(word.ToString()));
                }
                else
                {
                    result.Append(word);
                }
                result.Append(c);
                word.Clear();
            }
        }

        if (word.Length >= 4)
        {
            result.Append(AbbreviateWord(word.ToString()));
        }
        else
        {
            result.Append(word);
        }

        return result.ToString();

        // SOLUTION WITH REGEX
        //return Regex.Replace(inputSting, "[a-zA-Z]{4,}", match =>
        //{
        //    string word = match.Value;
        //    return word[0] + (word.Length - 2).ToString() + word[^1];
        //});
    }

    static string AbbreviateWord(string word)
    {
        return word[0] + (word.Length - 2).ToString() + word[^1];
    }

}
