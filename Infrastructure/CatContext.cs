using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class CatContext : DbContext
    {
        public CatContext(DbContextOptions<CatContext> opts) : base(opts) { }

        public DbSet<Cat> Cats { get; set; }
        public DbSet<Breed> Breeds { get; set; }
    }
}
