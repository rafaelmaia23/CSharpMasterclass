using System.Text.Json.Serialization;

namespace QuoteFinder.Models;

public record Root(
    [property: JsonPropertyName("statusCode")] int statusCode,
    [property: JsonPropertyName("message")] string message,
    [property: JsonPropertyName("pagination")] Pagination pagination,
    [property: JsonPropertyName("totalQuotes")] int totalQuotes,
    [property: JsonPropertyName("data")] IReadOnlyList<Datum> data
);


