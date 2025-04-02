using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pokemon151.Data;
using System;
using System.Linq;

namespace Pokemon151.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new Pokemon151Context(
            serviceProvider.GetRequiredService<
                DbContextOptions<Pokemon151Context>>()))
        {
            // Look for any pokemon.
            if (context.Pokemon.Any())
            {
                return;   // DB has been seeded
            }
            context.Pokemon.AddRange(
                new Pokemon

                {
                
                    Name = "Bulbasaur",
                    Height = "0.7m",
                    Weight = 6.9M
                }
              
            );
            context.SaveChanges();
        }
    }
}
