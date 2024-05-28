namespace QuoteFinder.DataAccess
{
    public class QuotesApiDataReader : IQuotesApiDataReader
    {
        private readonly HttpClient _httpClient = new HttpClient();
        public async Task<string> ReadAsync(int page, int quotesPerPage)
        {
            var endpoint = $"https://quote-garden.onrender.com/api/v3/quotes?limit={quotesPerPage}&page={page}";
            
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(endpoint);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
                throw; // Re-throw the exception to handle it in the caller method
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine($"Request timeout: {e.Message}");
                throw; // Re-throw the exception to handle it in the caller method
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
                throw; // Re-throw the exception to handle it in the caller method
            }

            //HttpResponseMessage response = await _httpClient.GetAsync(endpoint);
            //response.EnsureSuccessStatusCode();
            //return await response.Content.ReadAsStringAsync();
        }
        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}
