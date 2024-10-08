using ECommerceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI;

public class ECommerceDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductRating> ProductRatings { get; set; }

    public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Initial product model setup
        modelBuilder.Entity<Product>().HasKey(p => p.ProductID);
        modelBuilder.Entity<Product>().Property(p => p.ProductID).ValueGeneratedNever();

        // Configure the relationship between Product and Product rating
        modelBuilder.Entity<ProductRating>()
            .HasOne(p => p.Product)
            .WithMany()
            .HasForeignKey(p => p.ProductRatingID)
            .OnDelete(DeleteBehavior.Cascade);
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
        catch (DbUpdateException ex)
        {
            throw new Exception("An error occurred while saving changes to the database.", ex);
        }
    }
}