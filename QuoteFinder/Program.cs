using QuoteFinder.App;
using QuoteFinder.DataAccess;
using QuoteFinder.UserInteraction;

IUserInteraction _userInteraction = new ConsoleUserInteraction();

IQuoteFinderApp app = new QuoteFinderApp(
    _userInteraction,
    new InputValidator(_userInteraction),
    /*new QuotesApiDataReader(),*/
    new QuotesProcessor());


app.Run();