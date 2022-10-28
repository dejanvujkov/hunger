namespace Hunger.Startup;

public static class EnvironmentConfiguration
{
    public static void Configure(this WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();

        app.UseRouting();

        app.MapBlazorHub();
        app.MapFallbackToPage("/_Host");

    }

    // public static IEnumerable<Restaurant> RefreshRestaurants()
    // {
    //     if (!File.Exists("Restaurants.json")) return new List<Restaurant>();
    //     
    //     var json = File.ReadAllText("Restaurants.json");
    //     var restaurants = JsonConvert.DeserializeObject<IEnumerable<Restaurant>>(json);
    //
    //     return restaurants ?? throw new InvalidOperationException();
    // }
}