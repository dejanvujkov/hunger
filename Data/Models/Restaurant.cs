namespace Hunger.Data.Models;

public record Restaurant
{
    public string Name { get; set; }
    public List<string>? Type { get; set; }
    public RestaurantDetails Details { get; set; }
}