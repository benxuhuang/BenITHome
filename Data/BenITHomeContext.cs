using Microsoft.EntityFrameworkCore;

namespace BenITHome.Data
{
    public class BenITHomeContext : DbContext
    {
        public BenITHomeContext(
            DbContextOptions<BenITHomeContext> options)
            : base(options)
        {
        }

        public DbSet<BenITHome.Models.Article> Article { get; set; }
    }
}