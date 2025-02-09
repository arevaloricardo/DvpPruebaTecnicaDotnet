using DvpPruebaTecnica.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DvpPruebaTecnica.Infrastructure.Data;

public class SqlServerDbContext: DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<User> Users { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=PruebaTecnica;User Id=sa;Password=Password123;");
    }
}