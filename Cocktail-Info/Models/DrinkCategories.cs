using System.Text.Json.Serialization;

public class DrinkCategory
{
    [JsonPropertyName("strCategory")]
    public string? Category { get; set; }
}

public class DrinkCategoryResponse
{
    [JsonPropertyName("drinks")]
    public List<DrinkCategory>? CategoriesList { get; set; }
}