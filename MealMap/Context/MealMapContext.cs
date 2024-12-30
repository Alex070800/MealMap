namespace MealMap.Context;

using System.Configuration;
using MealMap.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

public class MealMapContext : DbContext
{

    public DbSet<MealType> MealTypes { get; set; }
    private string connectionString = "Server=localhost;User ID=root; Password=root; Database=meal_map;";
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseMySQL("Server=localhost;User ID=root; Password=root; Database=meal_map;");
        optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 25)));
        //optionsBuilder.ConfigureWarnings(w => w.Ignore(CoreEventId.LazyLoadOnDisposedContextWarning));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

    }
}
