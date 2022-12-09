using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // Db Tables - Columns are the data set (AppUser)
        public DbSet<AppUser> Users { get; set; }
    }
}