namespace QuoteFinder.UserInteraction;

public interface IUserInteraction
{
    void Write(string message);
    string? Read();
}
