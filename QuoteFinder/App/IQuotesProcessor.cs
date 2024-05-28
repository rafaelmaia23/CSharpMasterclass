using QuoteFinder.Models;

namespace QuoteFinder.App;

public interface IQuotesProcessor
{
    Task<Datum> Process(IEnumerable<Datum> quotes, string word);
}
