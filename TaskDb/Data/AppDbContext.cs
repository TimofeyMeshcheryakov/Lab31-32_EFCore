using System.Security.Cryptography.X509Certificates;
using System.Xml;
using Microsoft.EntityFrameworkCore;
using TaskDb.Models;

namespace TaskDb.Data;

public class AppDbContext : DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<TaskItem> Tasks { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<TaskItem>().HasData(
            new TaskItem {
                Id = 1,
                Title = "Изучить ASP.NET Core",
                Description = "Контроллеры, маршруты, middl"
            }
        )
    }
}