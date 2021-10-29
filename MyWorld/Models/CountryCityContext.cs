using System.Data.Entity;

namespace MyWorld.Models
{
    public class CountryCityContext : DbContext
    {
        public DbSet<Countries> Countries { get; set; }
        
        public DbSet<Cities> Cities { get; set; }
    }
}