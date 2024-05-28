using System.Text.RegularExpressions;

namespace QuoteFinder.UserInteraction;

public class InputValidator : IImputValidator
{
    private static string pattern = @"^[a-zA-Z]+$";
    private Regex _regex;
    private IUserInteraction _userInteraction;

    public InputValidator(IUserInteraction userInteraction)
    {
        _userInteraction = userInteraction;
        _regex = new Regex(pattern);
    }

    public bool IsNumberValid(string numberAsString, out int number)
    {
        if(int.TryParse(numberAsString, out number))
        {
            return true;
        }
        else
        {
            _userInteraction.Write("Invalid input. Please input a valid number!");
            return false;
        }
    }

    public bool IsWordValid(string word)
    {
        if(word is null)
        {
            _userInteraction.Write("The word cannot be null");
            return false;
        }
        if (_regex.IsMatch(word))
        {
            return true;
        }
        else
        {
            _userInteraction.Write("Word invalid. The word must be a single word without spaces and cannot contain numbers or special characters");
            return false;
        }
    }

    public bool ValidadeParallelInputChoice(string inputChoice)
    {
        if (inputChoice == "y") return true;
        else return false;
    }
}
