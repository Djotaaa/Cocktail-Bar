using System.Text.Json.Serialization;

public class DrinkSearchList
{
    [JsonPropertyName("drinks")]
    public List<DrinkSearch>? ListOfDrinks { get; set; }
}

public class DrinkSearch
{
    [JsonPropertyName("idDrink")]
    public string? Id { get; set; }

    [JsonPropertyName("strDrink")]
    public string? Name { get; set; }

    [JsonPropertyName("strCategory")]
    public string? Category { get; set; }

    [JsonPropertyName("strAlcoholic")]
    public string? Alcoholic { get; set; }
}