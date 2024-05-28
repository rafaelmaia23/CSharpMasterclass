using QuoteFinder.DataAccess;
using QuoteFinder.Models;
using QuoteFinder.UserInteraction;
using System.Text.Json;

namespace QuoteFinder.App;

public class QuoteFinderApp : IQuoteFinderApp
{
    private readonly IUserInteraction _userInteraction;
    private readonly IImputValidator _inputValidator;
    //private readonly IQuotesApiDataReader _quotesApiDataReader;
    private readonly IQuotesProcessor _quotesProcessor;

    public QuoteFinderApp(IUserInteraction userInteraction, 
        IImputValidator inputValidator, 
        //IQuotesApiDataReader quotesApiDataReader,
        IQuotesProcessor quotesProcessor)
    {
        _userInteraction = userInteraction;
        _inputValidator = inputValidator;
        //_quotesApiDataReader = quotesApiDataReader;
        _quotesProcessor = quotesProcessor;
    }

    public async void Run()
    {
        _userInteraction.Write("Welcome to the Quote Finder App!");

        string userChosenWord = ReadWord();
        int numberOfPages = ReadNumberOfPages();
        int numberOfQuotes = ReadNumberOfQuotes();
        bool parallelProcesse = ReadParallelProccess();
        _userInteraction.Write("Fetching data...");
        List<string> pagesFromApiAsString = await GetPagesFromApiAsString(numberOfPages, numberOfQuotes);
        _userInteraction.Write("Data is ready.");
        List<Root> pagesAsRoot = DeserializePagesFromApi(pagesFromApiAsString);
        List<Datum> quotes = new();
        foreach (var page in pagesAsRoot)
        {
            quotes.Add(await _quotesProcessor.Process(page.data, userChosenWord));
        }

        foreach (var quote  in quotes)
        {
            _userInteraction.Write($"{quote.quoteText} - {quote.quoteAuthor}");
        }
    }

    private static List<Root> DeserializePagesFromApi(List<string> pagesFromApiAsString)
    {
        var pagesAsRoot = new List<Root>();
        foreach (var page in pagesFromApiAsString)
        {
            pagesAsRoot.Add(JsonSerializer.Deserialize<Root>(page));
        }

        return pagesAsRoot;
    }

    private async Task<List<string>> GetPagesFromApiAsString(int numberOfPages, int numberOfQuotes)
    {
        List<string> pagesFromApiAsString = new List<string>();
        using var quotesApiDataReader = new QuotesApiDataReader();
        for (int i = 1; i <= numberOfPages; i++)
        {
            var responseBody = await quotesApiDataReader.ReadAsync(i, numberOfQuotes);
            pagesFromApiAsString.Add(responseBody);
        }

        return pagesFromApiAsString;
    }

    private bool ReadParallelProccess()
    {
        bool parallelProcesse;
        _userInteraction.Write("Shall process pages in parallel?? ('y' for 'yes', anything else for 'no'");
        parallelProcesse = _inputValidator.ValidadeParallelInputChoice(_userInteraction.Read());
        return parallelProcesse;
    }

    private int ReadNumberOfQuotes()
    {
        int numberOfQuotes;
        do
        {
            _userInteraction.Write("How many quotes do you want to check for each page?");

        } while (!_inputValidator.IsNumberValid(_userInteraction.Read(), out numberOfQuotes));
        return numberOfQuotes;
    }

    private int ReadNumberOfPages()
    {
        int numberOfPages;
        do
        {
            _userInteraction.Write("How many pages do you want to check for a quote with this word?");

        } while (!_inputValidator.IsNumberValid(_userInteraction.Read(), out numberOfPages));
        return numberOfPages;
    }

    private string ReadWord()
    {
        string userChosenWord;
        do
        {
            _userInteraction.Write("Please write a word so that we can search quotes that have that word for you: ");
            userChosenWord = _userInteraction.Read();
        } while (!_inputValidator.IsWordValid(userChosenWord));
        return userChosenWord;
    }
}
