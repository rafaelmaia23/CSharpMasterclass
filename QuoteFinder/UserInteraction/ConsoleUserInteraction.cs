namespace QuoteFinder.UserInteraction;

public class ConsoleUserInteraction : IUserInteraction
{
    public void Write(string message)
    {
        Console.WriteLine(message);
    }

    public string? Read()
    {
        return Console.ReadLine();
    }
}
