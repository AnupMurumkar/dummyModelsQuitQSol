using Microsoft.EntityFrameworkCore;

namespace dummyModelsQuitQ.Models.EFCoreDBContextFiles
{
    public class EFDbContext : DbContext
    {
        public EFDbContext() { }

        public EFDbContext(DbContextOptions<EFDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=KHUSHI\\SQLEXPRESS,Databse=EFCoreDemo;" + "Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True;");
            optionsBuilder.UseSqlServer("Server=LAPTOP-8JT18MT0;Database= ModelsDemo;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True;");

        }

        //Data Source=LAPTOP-8JT18MT0;Initial Catalog=TicketBookingSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True

        public DbSet<User> Users { get; set; }
        public DbSet<SellerDetail> SellerDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInventory> ProductInventories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Payment> Payments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Products -> Users relationship to prevent cascading deletes
            modelBuilder.Entity<Product>()
                .HasOne<User>() // No navigation property in User
                .WithMany()     // No collection in User
                .HasForeignKey(p => p.UserID)
                .OnDelete(DeleteBehavior.NoAction);  // Prevent cascade delete

            // Configure Products -> Categories relationship to prevent cascading deletes
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryID)
                .OnDelete(DeleteBehavior.NoAction);  // Prevent cascade delete

            modelBuilder.Entity<Payment>()
            .HasOne(p => p.Order)
            .WithMany()
            .HasForeignKey(p => p.OrderID)
            .OnDelete(DeleteBehavior.NoAction); // Prevent cascade delete

            // Configure Payments -> Users relationship
            modelBuilder.Entity<Payment>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(p => p.UserID)
                .OnDelete(DeleteBehavior.NoAction); // Prevent cascade delete

            modelBuilder.Entity<CartItem>()
           .HasOne(ci => ci.Cart)
           .WithMany(c => c.CartItems)
           .HasForeignKey(ci => ci.CartID)
           .OnDelete(DeleteBehavior.NoAction); // Prevent cascade delete

            // Configure CartItems -> Products relationship to prevent cascading delete
            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Product)
                .WithMany()
                .HasForeignKey(ci => ci.ProductID)
                .OnDelete(DeleteBehavior.NoAction); // Prevent cascade delete

            // Configure OrderItems -> Orders to prevent cascading delete
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderID)
                .OnDelete(DeleteBehavior.NoAction); // Prevent cascade delete

            // Configure OrderItems -> Products to prevent cascading delete
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)
                .WithMany()
                .HasForeignKey(oi => oi.ProductID)
                .OnDelete(DeleteBehavior.NoAction); // Prevent cascade delete

            base.OnModelCreating(modelBuilder);
        }
    }


}