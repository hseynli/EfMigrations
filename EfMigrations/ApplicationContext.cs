using Microsoft.EntityFrameworkCore;

namespace EfMigrations;

internal class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=EfMigrations;Integrated Security=True;TrustServerCertificate=True;");
    }
}
