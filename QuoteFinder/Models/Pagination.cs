using System.Text.Json.Serialization;

namespace QuoteFinder.Models;

public record Pagination(
    [property: JsonPropertyName("currentPage")] int currentPage,
    [property: JsonPropertyName("nextPage")] int nextPage,
    [property: JsonPropertyName("totalPages")] int totalPages
);
