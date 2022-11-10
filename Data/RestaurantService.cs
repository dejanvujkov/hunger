using Hunger.Data.Models;
using Newtonsoft.Json;

namespace Hunger.Data;

public class RestaurantService
{
    public async Task<IEnumerable<Restaurant?>?> GetAllRestaurants()
    {
        return await ReadRestaurantFile();
    }

    public async Task<Restaurant?> GetRandomRestaurant()
    {
        var allRestaurants = await ReadRestaurantFile();
        var restaurants = allRestaurants as Restaurant[] ?? allRestaurants.ToArray();
        return restaurants.ElementAtOrDefault(Random.Shared.Next(restaurants.Length));
    }

    public async Task<IEnumerable<Restaurant?>?> GetRestaurantByType(string? type)
    {
        var restaurants = await ReadRestaurantFile();
        return string.IsNullOrEmpty(type) ? null : restaurants.Where(r => r.Type != null && r.Type.Contains(type));
    }

    private Task<IEnumerable<Restaurant>> ReadRestaurantFile()
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Files", "Restaurants.json");
        if (!File.Exists(path)) return Task.FromResult<IEnumerable<Restaurant>>(new List<Restaurant>());
        
        var json = File.ReadAllText(path);
        var restaurants = JsonConvert.DeserializeObject<IEnumerable<Restaurant>>(json);
        
        return Task.FromResult(restaurants ?? new List<Restaurant>());
    }
}