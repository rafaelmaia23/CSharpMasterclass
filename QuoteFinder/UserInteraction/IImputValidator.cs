namespace QuoteFinder.UserInteraction;

public interface IImputValidator
{
    bool IsWordValid(string word);

    bool IsNumberValid(string numberAsString, out int number);

    bool ValidadeParallelInputChoice(string inputChoice);
}
