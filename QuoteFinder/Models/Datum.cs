using System.Text.Json.Serialization;

namespace QuoteFinder.Models;

public record Datum(
    [property: JsonPropertyName("_id")] string _id,
    [property: JsonPropertyName("quoteText")] string quoteText,
    [property: JsonPropertyName("quoteAuthor")] string quoteAuthor,
    [property: JsonPropertyName("quoteGenre")] string quoteGenre,
    [property: JsonPropertyName("__v")] int __v
);
