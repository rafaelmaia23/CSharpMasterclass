namespace StarWarsStats.StarWarsStatsApp
{
    public interface IConsoleUserInteraction
    {
        void PromptUser();
        string ReadInput();
        void WriteMessage(string message);
    }
}