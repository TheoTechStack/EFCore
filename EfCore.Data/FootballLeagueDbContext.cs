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
}