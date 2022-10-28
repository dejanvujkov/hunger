namespace Hunger.Data.Models;

public record RestaurantDetails
{
    public string Address { get; set; }
    public List<RestaurantDish> SignatureDishes { get; set; }
    public bool HasVegetarianDishes => SignatureDishes.Any(dish => dish.IsVegetarian);
}