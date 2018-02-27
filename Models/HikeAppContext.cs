using Microsoft.EntityFrameworkCore;

namespace hikeapp.Models
{
    public class HikeAppContext : DbContext
    {
        public HikeAppContext(DbContextOptions<HikeAppContext> options) : base(options) {}

        public DbSet<User> Users {get; set;}
        
    }
}