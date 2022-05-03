using Microsoft.EntityFrameworkCore;
using PromotigoMVC.Models;

namespace PromotigoMVC.data
{
    public class PromotigoMVCDBContext : DbContext
    {
        public PromotigoMVCDBContext(DbContextOptions<PromotigoMVCDBContext> options) :base(options) { }
        public DbSet<Entrant>? Entrant { get; set; }
    }

}
