using StarWarsStats.DataAccess;
using StarWarsStats.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StarWarsStats.StarWarsStatsApp
{
    public class StarWarsStatsApp
    {
        private readonly IApiDataReader _apiDataReader;
        private readonly ITablePrinter _tablePrinter;
        private readonly IConsoleUserInteraction _userInteraction;

        private const string baseAdress = "https://swapi.py4e.com/api/";
        private const string requestUri = "planets/";

        public StarWarsStatsApp(IApiDataReader apiDataReader, ITablePrinter tablePrinter, IConsoleUserInteraction userInteraction)
        {
            _apiDataReader = apiDataReader;
            _tablePrinter = tablePrinter;
            _userInteraction = userInteraction;
        }

        public async Task Run()
        {
            var json = await _apiDataReader.Read(baseAdress, requestUri);
            var root = JsonSerializer.Deserialize<Root>(json);
            IEnumerable<Planet> planets = PopulatePlanets(root);
            _tablePrinter.Print(planets);
            _userInteraction.PromptUser();
            var userInput = _userInteraction.ReadInput();
            GetPlanetsDataResult(planets, userInput);
        }

        private void GetPlanetsDataResult(IEnumerable<Planet> planets, string propertyName)
        {
            var orderedPlanets = planets
                .Where(planet => planet.GetType().GetProperty(propertyName).GetValue(planet) != null)
                .OrderBy(planet => planet.GetType().GetProperty(propertyName).GetValue(planet, null).ToString())
                .ToList();
            var max = orderedPlanets.Last();
            var min = orderedPlanets.First();
            _userInteraction.WriteMessage($"Max {propertyName} " +
                $"is {max.GetType().GetProperty(propertyName).GetValue(max, null).ToString()} " +
                $"(planet: {max.Name}");
            _userInteraction.WriteMessage($"Min {propertyName} " +
                $"is {min.GetType().GetProperty(propertyName).GetValue(min, null).ToString()} " +
                $"(planet: {min.Name}");
        }

        private IEnumerable<Planet> PopulatePlanets(Root root)
        {
            List<Planet> planets = new();
            foreach (var result in root.results)
            {
                planets.Add(new Planet(result.name, result.population, result.diameter, result.surface_water));
            }
            return planets;
        }
    }
}
