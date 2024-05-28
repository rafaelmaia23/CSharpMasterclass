namespace StarWarsStats_Te.ApiDataAccess;

public interface IApiDataReader
{
Task<string> Read(string baseAddress, string requestUri);
}