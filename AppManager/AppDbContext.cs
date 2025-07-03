using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<AppRecord> AppRecords { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
        optionsBuilder.UseSqlite("Data Source=appdata.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AppRecord>()
            .HasIndex(a => new { a.AppId, a.AppTech })
            .IsUnique(); // UNIQUE CONSTRAINT CHECK
    }
}
