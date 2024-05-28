using StarWarsStats_Te.ApiDataAccess;

try
{
    var consoleUserInteractor = new ConsoleUserInteractor();
    var planetsStatsUserInteractor = new PlanetsStatsUserInteractor(consoleUserInteractor);

    await new StarWarsStatsApp(
        new PlanetsFromApiReader(
            new ApiDataReader(),
            new MockStarWarsApiDataReader(),
            consoleUserInteractor),
        new PlanetsStaticticsAnalizer(
            planetsStatsUserInteractor),
        planetsStatsUserInteractor).Run();
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred." +
        "Exception message: " + ex.Message); 
}
Console.ReadLine();
