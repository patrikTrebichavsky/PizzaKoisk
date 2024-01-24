using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using PizzaKiosk.Model;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<KoiskContext>();

var app = builder.Build();

app.MapGet("/", WebApiV1.GetAllPizzas);

public static class WebApiV1
{
    public static async Task<Ok<Pizza[]>> GetAllPizzas(KoiskContext context)
    {
        Pizza[] pizzas = await context.Pizzas.ToArrayAsync();

        return TypedResults.Ok(pizzas);
    }
}
