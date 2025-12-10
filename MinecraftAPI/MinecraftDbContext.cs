using MinecraftAPI.Models; // đúng với namespace trong Resources.cs
using Microsoft.EntityFrameworkCore;

namespace Assignment.Data
{
    public class MinecraftDbContext : DbContext
    {
        public MinecraftDbContext(DbContextOptions<MinecraftDbContext> options)
            : base(options) { }

        // Bảng Resources
        public DbSet<Resources> Resources { get; set; }

        
    }
}