using Microsoft.EntityFrameworkCore;
using ImageUploadService.Models;

namespace ImageUploadService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        // Adicione outros DbSets futuramente
    }
} 