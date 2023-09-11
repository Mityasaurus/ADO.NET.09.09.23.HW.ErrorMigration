using Microsoft.EntityFrameworkCore;
using Models;
using System.Configuration;

namespace Spanish_Football_Championship
{
    public class ChampionshipContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Default"].ToString());
            base.OnConfiguring(optionsBuilder);
        }
    }
}