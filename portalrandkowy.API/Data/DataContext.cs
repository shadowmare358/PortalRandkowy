using Microsoft.EntityFrameworkCore;
using portalrandkowy.API.Models;

namespace portalrandkowy.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Value> Values { get; set; }
    }
}