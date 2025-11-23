using Microsoft.EntityFrameworkCore;
using InventoryAPI.Models;

namespace InventoryAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<StockTransaction> StockTransactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Product configuration
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.SKU).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Price).HasColumnType("decimal(18,2)");
                entity.HasIndex(e => e.SKU).IsUnique();

                entity.HasOne(e => e.Supplier)
                    .WithMany(s => s.Products)
                    .HasForeignKey(e => e.SupplierId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Supplier configuration
            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Email).HasMaxLength(100);
            });

            // StockTransaction configuration
            modelBuilder.Entity<StockTransaction>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.HasOne(e => e.Product)
                    .WithMany()
                    .HasForeignKey(e => e.ProductId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // Seed data
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            // Seed Suppliers
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { Id = 1, Name = "Scandinavian Furniture Co.", ContactPerson = "Erik Larsson", Email = "erik@scandi.com", Phone = "+46-123-456", Address = "Stockholm, Sweden" },
                new Supplier { Id = 2, Name = "Baltic Wood Supplies", ContactPerson = "Anna Kowalski", Email = "anna@baltic.com", Phone = "+48-987-654", Address = "Gdansk, Poland" }
            );

            // Seed Products
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, SKU = "BILLY-001", Name = "BILLY Bookcase", Description = "Adjustable shelves", Category = "Storage", Price = 79.99m, StockQuantity = 150, MinimumStock = 20, SupplierId = 1, Location = "Warehouse A-1" },
                new Product { Id = 2, SKU = "EKTORP-001", Name = "EKTORP Sofa", Description = "3-seat sofa with removable cover", Category = "Furniture", Price = 599.99m, StockQuantity = 25, MinimumStock = 5, SupplierId = 1, Location = "Warehouse B-3" },
                new Product { Id = 3, SKU = "LACK-001", Name = "LACK Coffee Table", Description = "Easy to assemble", Category = "Tables", Price = 49.99m, StockQuantity = 200, MinimumStock = 30, SupplierId = 2, Location = "Warehouse A-2" },
                new Product { Id = 4, SKU = "MALM-001", Name = "MALM Bed Frame", Description = "Queen size with storage", Category = "Bedroom", Price = 299.99m, StockQuantity = 15, MinimumStock = 10, SupplierId = 2, Location = "Warehouse C-1" }
            );
        }
    }
}