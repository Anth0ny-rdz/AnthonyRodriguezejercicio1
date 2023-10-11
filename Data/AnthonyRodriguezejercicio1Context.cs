using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AnthonyRodriguezejercicio1.Models;

namespace AnthonyRodriguezejercicio1.Data
{
    public class AnthonyRodriguezejercicio1Context : DbContext
    {
        public AnthonyRodriguezejercicio1Context (DbContextOptions<AnthonyRodriguezejercicio1Context> options)
            : base(options)
        {
        }

        public DbSet<AnthonyRodriguezejercicio1.Models.Burger> Burger { get; set; } = default!;
    }
}
