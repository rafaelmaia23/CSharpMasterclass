using QuoteFinder.Models;
using System.Text.Json;

namespace QuoteFinder.DataAccess.Mock;

//this class may be used to get quotes in case Quotes Garden API is down
//it can be used where QuotesApiDataReader is used,
//as they implement the same interface
//it generates quotes using 500 most common English words
//so, of course, the quotes are nonesense
public class MockQuotesApiDataReader : IQuotesApiDataReader
{
    private readonly Random _random = new Random();

    public Task<string> ReadAsync(int page, int quotesPerPage)
    {
        var root = new Root
        (
            200,
            "ok",
             new Pagination (1, 2, page),
            quotesPerPage,
            GenerateRandomData(quotesPerPage)
        );

        return Task.FromResult(JsonSerializer.Serialize(root));
    }

    private List<Datum> GenerateRandomData(int quotesPerPage)
    {
        return Enumerable.Range(0, quotesPerPage).Select(i =>
        new Datum
        (
            "1",
            GenerateRandomQuote(),
            "Unknown",
            "",
            1
        )).ToList();
    }

    private string GenerateRandomQuote()
    {
        var length = _random.Next(5, 30);

        return string
            .Join(" ", Enumerable.Range(0, length)
            .Select(i => GetRandomWord()));
    }

    private string GetRandomWord()
    {
        var index = _random.Next(0, Words.All.Length);
        return Words.All[index];
    }

    public void Dispose()
    {
    }
}

