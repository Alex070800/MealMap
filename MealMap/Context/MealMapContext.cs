namespace MealMap.Context;

using System.Configuration;
using MealMap.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

public class MealMapContext : DbContext
{
    private string connectionString = "Server=localhost;User ID=root; Password=root; Database=meal_map;";

    public DbSet<MealType> MealTypes { get; set; }
    public DbSet<Unit> Units { get; set; }

    public DbSet<Product> Products { get; set; }   
    
    public DbSet<Category> Categories { get; set; }
    public DbSet<Family> Families { get; set; }
    public DbSet<User> Users { get; set; }

    public DbSet<Menu> Menu { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 25)));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //products <-> categories
        modelBuilder.Entity<Product>()
           .HasOne(p => p.Category)
           .WithMany()
           .HasForeignKey("category_id");

        //family.master <-> user
        modelBuilder.Entity<Family>()
            .HasOne(f => f.Master)
            .WithMany()
            .HasForeignKey("master_id");

        //family <-> user
        modelBuilder.Entity<Family>()
            .HasMany(f => f.Users)
            .WithOne(u => u.Family)
            .HasForeignKey("family_id");

        //family <-> menu
        modelBuilder.Entity<Family>()
           .HasOne(f => f.Menu)
           .WithOne()
           .HasForeignKey<Menu>(m => m.Id);

    }
}
