using StarWarsStats.DataAccess;
using StarWarsStats.StarWarsStatsApp;

try
{
    var app = new StarWarsStatsApp(new ApiDataReader(), new TablePrinter(), new ConsoleUserInteraction());
    await app.Run();
}
catch (Exception ex)
{
    Console.WriteLine($"Some unexpected error occur. The App will close. {ex.Message}");
}