using Microsoft.EntityFrameworkCore;
using MVCNorthWind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCNorthWind.Data
{
    public class NorthWindContext:DbContext
    {
        public NorthWindContext(DbContextOptions<NorthWindContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
