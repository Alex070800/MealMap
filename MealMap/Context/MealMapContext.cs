namespace MealMap.Context;

using MealMap.Models;
using Microsoft.EntityFrameworkCore;

public class MealMapContext : DbContext
{
    private string connectionString = "Server=localhost;User ID=root; Password=root; Database=meal_map;";

    public DbSet<Agreement> Agreements { get; set; }
    public DbSet<MealType> MealTypes { get; set; }
    public DbSet<Unit> Units { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Family> Families { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Component> Components { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Menu> Menu { get; set; }
    public DbSet<Day> Days { get; set; }
    public DbSet<Desk> Desks { get; set; }
    public DbSet<Dish> Dishes { get; set; }

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
        //modelBuilder.Entity<User>()
        //    .HasOne(u => u.Family)
        //    .WithMany(Family => Family.Users)
        //    .HasForeignKey("family_id");

        //family <-> menu
        //modelBuilder.Entity<Family>()
        //   .HasOne(f => f.Menu)
        //   .WithOne()
        //   .HasForeignKey<Family>(f => f.Id);
        modelBuilder.Entity<Family>()
              .HasOne(f => f.Menu)
              .WithOne()
              .HasForeignKey<Menu>(m => m.Id)
              .IsRequired();

        //recipe <-> component
        modelBuilder.Entity<Recipe>()
            .HasMany(r => r.Components)
            .WithOne()
            .HasForeignKey("recipe_id");

        //recipe <-> user
        modelBuilder.Entity<User>()
            .HasMany(u => u.Recipes)
            .WithOne()
            .HasForeignKey("user_id");

        //component <-> unit
        modelBuilder.Entity<Component>()
            .HasOne(c => c.Unit)
            .WithMany()
            .HasForeignKey("unit_id");

        //component <-> product
        modelBuilder.Entity<Component>()
            .HasOne(c => c.Product)
            .WithMany()
            .HasForeignKey("product_id");

        //dish <-> user
        modelBuilder.Entity<User>()
            .HasMany(u => u.Dishes)
            .WithOne(d => d.User)
            .HasForeignKey("id_user");

        //dish <-> recipe
        modelBuilder.Entity<Dish>()
            .HasOne(d => d.Recipe)
            .WithMany()
            .HasForeignKey("id_recipe");

        //menu <-> day
        modelBuilder.Entity<Menu>()
            .HasMany(m => m.Days)
            .WithOne()
            .HasForeignKey("id_menu");

        //day <-> desk
        modelBuilder.Entity<Day>()
            .HasMany(d => d.Desks)
            .WithOne()
            .HasForeignKey("day_id");

        //dish <-> desk
        modelBuilder.Entity<Desk>()
            .HasMany(d => d.Dishs)
            .WithOne()
            .HasForeignKey("id_desk");

        //desk <-> mealType
        modelBuilder.Entity<Desk>()
            .HasOne(d => d.Type)
            .WithMany()
            .HasForeignKey("meal_type_id");

        //agreement <-> user
        modelBuilder.Entity<Agreement>()
            .HasOne(a => a.User)
            .WithMany()
            .HasForeignKey("user_id");

        //agreement <-> desk
        modelBuilder.Entity<Agreement>()
            .HasOne(a => a.Desk)
            .WithMany(d => d.Agreements)
            .HasForeignKey("desk_id");
    }
}
