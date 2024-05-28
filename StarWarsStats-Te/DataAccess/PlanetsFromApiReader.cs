using StarWarsStats_Te.ApiDataAccess;
using StarWarsStats_Te.DTOs;
using System.Text.Json;

public class PlanetsFromApiReader : IPlanetsReader
{
    private readonly IApiDataReader _apiDataReader;
    private readonly IApiDataReader _secondaryApiDataReader;
    private readonly IUserInteractor _UserInteractor;

    public PlanetsFromApiReader(IApiDataReader apiDataReader, IApiDataReader secondaryApiDataReader, IUserInteractor userInteractor)
    {
        _apiDataReader = apiDataReader;
        _secondaryApiDataReader = secondaryApiDataReader;
        _UserInteractor = userInteractor;
    }

    public async Task<IEnumerable<Planet>> Read()
    {
        string? json = null;

        try
        {

            json = await _apiDataReader.Read("https://swapi.dev/", "api/planets");
        }
        catch (HttpRequestException ex)
        {
            _UserInteractor.ShowMessage("API request was unsuccessful. " +
                "Swittching to mock data." +
                "Exception message: " + ex.Message);
        }

        json ??= await _secondaryApiDataReader.Read("https://swapi.dev/", "api/planets");

        var root = JsonSerializer.Deserialize<Root>(json);

        return ToPlanets(root);
    }

    private static IEnumerable<Planet> ToPlanets(Root? root)
    {
        if (root is null)
        {
            throw new ArgumentNullException(nameof(root));
        }

        return root.results.Select(planetDto => (Planet)planetDto);
    }
}
