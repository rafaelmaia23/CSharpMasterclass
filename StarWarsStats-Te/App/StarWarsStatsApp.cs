public class StarWarsStatsApp
{
    private readonly IPlanetsReader _planetsReader;
    private readonly IPlanetsStaticticsAnalizer _planetsStaticticsAnalizer;
    private readonly IPlanetsStatsUserInteractor _planetsStatsUserInteractor;

    public StarWarsStatsApp(IPlanetsReader planetsReader, IPlanetsStaticticsAnalizer planetsStaticticsAnalizer, IPlanetsStatsUserInteractor planetsStatsUserInteractor)
    {
        _planetsReader = planetsReader;
        _planetsStaticticsAnalizer = planetsStaticticsAnalizer;
        _planetsStatsUserInteractor = planetsStatsUserInteractor;
    }

    public async Task Run()
    {
        var planets = await _planetsReader.Read();

        _planetsStatsUserInteractor.Show(planets);

        _planetsStaticticsAnalizer.Analyze(planets);
    }
}
