using QuoteFinder.Models;

namespace QuoteFinder.App;

public class QuotesProcessor : IQuotesProcessor
{
    public async Task<Datum> Process(IEnumerable<Datum> quotes, string word)
    {
        var quotesWithWord = quotes.Where(quote => quote.quoteText.Contains(word)).ToList();
        if(quotesWithWord.Count == 0)
        {
            return new Datum("null", "No quotes on this page with this word", "", "", 0);
        }
        var smallestQuote = quotesWithWord.OrderBy(quote => quote.quoteText.Length).FirstOrDefault();
        return smallestQuote;
    }
}