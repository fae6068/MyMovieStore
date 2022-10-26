using Microsoft.EntityFrameworkCore;

namespace MyMovieStore.Models
{
    public class DefaultConnection : DbContext
    {
        public DefaultConnection(DbContextOptions<DefaultConnection> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
