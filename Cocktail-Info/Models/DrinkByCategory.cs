using System.Text.Json.Serialization;

public class DrinkByCategory
{
    [JsonPropertyName("idDrink")]
    public string? Id { get; set; }

    [JsonPropertyName("strDrink")]
    public string? Name { get; set; }
}

public class DrinksByCategoryList
{
    [JsonPropertyName("drinks")]
    public List<DrinkByCategory>? ListOfDrinks { get; set; }
}