using System.Data;
using EfCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace EfCore.Data;

public class FootballLeagueDbContext : DbContext
{
    public DbSet<Team> Teams { get; set; }
    public DbSet<Coach> Coaches { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlServer("");
        optionsBuilder.UseSqlite("Data Source=FootballLeague_Efcore.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Team>().HasData(
            new Team
            {
                TeamId = 1,
                Name = "Manchester FC",
                CreatedDate = DateTimeOffset.UtcNow.DateTime
            },    
            new Team
            {
                TeamId = 2,
                Name = "Juventus",
                CreatedDate = DateTimeOffset.UtcNow.DateTime
            },
            new Team
            {
                TeamId = 3,
                Name = "Chelsea",
                CreatedDate = DateTimeOffset.UtcNow.DateTime
            }
        );
    }
}