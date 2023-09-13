using Microsoft.EntityFrameworkCore;
using Models;
using System.Configuration;

namespace Spanish_Football_Championship
{
    public class ChampionshipContext : DbContext
    {
        private static string ConnString => ConfigurationManager.ConnectionStrings["Default"].ToString();
        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SpanishFootballChampionship;Integrated Security=True;Connect Timeout=30;";
            optionsBuilder.UseSqlServer(ConnString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}