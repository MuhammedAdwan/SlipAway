using Microsoft.EntityFrameworkCore;
using SlipAway.Models;

namespace SlipAway.Data
{
    public class SlipAwayContext : DbContext
    {
        public SlipAwayContext (DbContextOptions<SlipAwayContext> options) : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }

    }
}
