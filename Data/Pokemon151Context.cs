using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pokemon151.Models;

namespace Pokemon151.Data
{
    public class Pokemon151Context : DbContext
    {
        public Pokemon151Context (DbContextOptions<Pokemon151Context> options)
            : base(options)
        {
        }

        public DbSet<Pokemon151.Models.Pokemon> Pokemon { get; set; } = default!;
    }
}
