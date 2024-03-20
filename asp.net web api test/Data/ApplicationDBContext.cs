using asp.net_web_api_test.Models;
using Microsoft.EntityFrameworkCore;

namespace asp.net_web_api_test.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions )
            : base (dbContextOptions)
        {

        }

        public DbSet<Stock>  Stock { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}
