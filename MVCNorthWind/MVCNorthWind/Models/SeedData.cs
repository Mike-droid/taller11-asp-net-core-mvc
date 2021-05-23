using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCNorthWind.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCNorthWind.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var Context = new NorthWindContext(serviceProvider.GetRequiredService<DbContextOptions<NorthWindContext>>());
            if (!Context.Products.Any())
            {
                Context.Products.AddRange(
                    new Product
                    {
                        Name = "Machacado",
                        RegisterDate = new DateTime(2020, 10, 10),
                        Category = "Carnes",
                        UnitPrice = 45.45m
                    },
                    new Product
                    {
                        Name = "Empanada",
                        RegisterDate = new DateTime(2020, 1, 22),
                        Category = "Harinas",
                        UnitPrice = 21.95m
                    }
                );
                Context.SaveChanges();
            }
        }
    }
}
