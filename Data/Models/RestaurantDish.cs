namespace Hunger.Data.Models;

public record RestaurantDish
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsVegetarian { get; set; }
    public string Description { get; set; }
}    