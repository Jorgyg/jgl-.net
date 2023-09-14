using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options) : base(options) { }
        public DbSet<Cliente> Cliente { get; set; } = null;
    }
}
