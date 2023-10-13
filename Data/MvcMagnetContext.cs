using Microsoft.EntityFrameworkCore;
using MvcMagnet.Models;

namespace MvcMagnet.Data
{
    public class MvcMagnetContext : DbContext
    {
        public MvcMagnetContext(DbContextOptions<MvcMagnetContext> options)
            : base(options)
        {
        }

        public DbSet<Magnet> Magnet { get; set; }
    }
}
