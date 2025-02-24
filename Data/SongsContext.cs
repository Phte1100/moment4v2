using moment4v2.Models;
using Microsoft.EntityFrameworkCore;

namespace moment4v2.Data {
    public class SongsContext : DbContext {
        public SongsContext(DbContextOptions<SongsContext> options) : base(options) { }
        public DbSet<Song> Songs { get; set; }
    }
}