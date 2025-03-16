using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Borrowing> Borrowings { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuration des relations
        modelBuilder.Entity<Borrowing>()
            .HasOne(b => b.Book)
            .WithMany(b => b.Borrowings)
            .HasForeignKey(b => b.BookId);

        modelBuilder.Entity<Borrowing>()
            .HasOne(b => b.AppUser)
            .WithMany(u => u.Borrowings)
            .HasForeignKey(b => b.AppUserId);
    }
}